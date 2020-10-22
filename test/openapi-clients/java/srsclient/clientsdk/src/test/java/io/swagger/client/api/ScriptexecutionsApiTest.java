/*
 * Script Runtime Service for vSphere
 * # Script Runtime Service API    Script Runtime Service for vSphere (SRS) allows running PowerShell and PowerCLI scripts. SRS is a VC add-on that is deployed separately from VCSA. SRS can be accessed via REST API that allows you to create PowerShell instances and run PowerShell and PowerCLI scripts within. No Connect-VIServer is required to run PowerCLI against VC(s) SRS is registered to.    ## Authetication    SRS uses VC SSO as Identity and Authentication Server. Two types of authentication are supported. SIGN and Basic. SIGN authentication is purposed for Service-To-Service access to SRS resources. For convenience of the end-users SRS supports basic authentication passing username and password which are used to acquire SAML HoK token for SRS solution. When basic is used SRS exchanges the username and password for SAML HoK token from the SSO server. SRS uses the SAML token to Connect PowerCLI to VC services in further operations.   On successful authentication SRS returns API Key which is required to authorize further SRS API calls.
 *
 * OpenAPI spec version: 1.0-oas3
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiException;
import io.swagger.client.model.ErrorDetails;
import io.swagger.client.model.ScriptExecution;
import io.swagger.client.model.StreamRecord;
import io.swagger.client.model.StreamType;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for ScriptexecutionsApi
 */
@Ignore
public class ScriptexecutionsApiTest {

    private final ScriptexecutionsApi api = new ScriptexecutionsApi();

    /**
     * Cancels a script execution
     *
     * ### Cancel a script execution  This operation is equivalent of pressing Ctrl+C in the PowerShell console. If the script is cancellable it will be cancelled.  The state of the **script execution** will become cancelled after this operation. The operation is asynchronous. Cancel request  is sent to the runtime.    ### Returns  The operation doesn&#x27;t return value. **200 Ok** will be returned if the request is successful.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void cancelScriptExecutionTest() throws ApiException {
        String id = null;
        api.cancelScriptExecution(id);

        // TODO: test validations
    }
    /**
     * Creates a script execution
     *
     * ### Create a script execution  **Script execution** represents asynchronous execution of a script in a specified **runspace**  When created **script execution** starts running in the **runspace**. To monitor the script execution  progress polling of the resource by its identifier should be used.  ### Retruns  When request is accepted **202 Accepted** with **Location** header is returned in the response that leads you to the **script execution** resource that is in running state initially.  When script execution is requested with non existing runspace  **404 Not Found** is returned.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void createScriptExecutionTest() throws ApiException {
        ScriptExecution body = null;
        ScriptExecution response = api.createScriptExecution(body);

        // TODO: test validations
    }
    /**
     * Retrieve a script execution
     *
     * ### Retrieve a script execution  Retrieves the details of a **script execution**. You need only supply the unique script execution identifier that was returned on script execution creation.        ### Returns  Returns a **script execution** resource instance if a valid identifier was provided.  When requesting the Id of a script execution that doesn&#x27;t exist **404 NotFound** is returned.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getScriptExecutionTest() throws ApiException {
        String id = null;
        ScriptExecution response = api.getScriptExecution(id);

        // TODO: test validations
    }
    /**
     * Retrieves output objects produced by a script execution.
     *
     * ### Retrieves output objects produced by a script execution ###  Output object could be in different format depending on the requested output object format on **script execution** request.  Text and json are currently supported.  When text is requested the objects that are produces ad an output by the script execution are formatted in table, the same way Format-Table formats the objects in PowerShell. Each item in the list of string represents single line of formatted output.  When output is formatted in json custom json formatting is used to serialize the objects produced by the script execution. The json object contain type name and full name of the interfaces the object implements. This is suitable if you want to present the objects in some context.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getScriptExecutionOutputTest() throws ApiException {
        String id = null;
        List<String> response = api.getScriptExecutionOutput(id);

        // TODO: test validations
    }
    /**
     * Retrieves list of stream records received during script execution.
     *
     * ### Retrieves list of stream records received during script execution  During execution of a script the script execution engine collects streams that are produced by the script execution.  There are five types of stream: information, error, warning, debug, verbose.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getScriptExecutionStreamTest() throws ApiException {
        String id = null;
        StreamType streamType = null;
        List<StreamRecord> response = api.getScriptExecutionStream(id, streamType);

        // TODO: test validations
    }
    /**
     * List all script executions
     *
     * ### List all script executions        ### Returns  Returns a list of your script executions.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void listScriptExecutionsTest() throws ApiException {
        List<ScriptExecution> response = api.listScriptExecutions();

        // TODO: test validations
    }
}
