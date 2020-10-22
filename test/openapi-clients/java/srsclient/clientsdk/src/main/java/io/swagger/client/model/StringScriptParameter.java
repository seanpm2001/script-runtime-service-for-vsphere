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

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * StringScriptParameter
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-10-09T07:53:20.504Z[GMT]")
public class StringScriptParameter implements AnyOfScriptExecutionScriptParametersItems {
  @SerializedName("value")
  private Object value = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("script")
  private String script = null;

  public StringScriptParameter value(Object value) {
    this.value = value;
    return this;
  }

   /**
   * Object that will be passed as an argument to a given parameter. Value, script, or both can be provided as an  argument. If only value is provided without script the object is passed to the script&#x27;s parameter as is.
   * @return value
  **/
  @Schema(description = "Object that will be passed as an argument to a given parameter. Value, script, or both can be provided as an  argument. If only value is provided without script the object is passed to the script's parameter as is.")
  public Object getValue() {
    return value;
  }

  public void setValue(Object value) {
    this.value = value;
  }

  public StringScriptParameter name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Name of the parameter. When a parameter is specified on a script execution create the name should match  the name of the parameter that is defined in the script.
   * @return name
  **/
  @Schema(required = true, description = "Name of the parameter. When a parameter is specified on a script execution create the name should match  the name of the parameter that is defined in the script.")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public StringScriptParameter script(String script) {
    this.script = script;
    return this;
  }

   /**
   * Script to be executed for this parameter. Value produced by the script will be the argument for the parameter.    In case a script is specified as an argument for a script parameter the service runs the script of the  parameter before running the requested script. The value that is produced as an output is used  as an argument for the script parameter.  If both script and value are specified for a script parameter the script is executed with single argument  with value specified in the value field. The object that is produced as an output is used as an argument  for the script parameter.
   * @return script
  **/
  @Schema(description = "Script to be executed for this parameter. Value produced by the script will be the argument for the parameter.    In case a script is specified as an argument for a script parameter the service runs the script of the  parameter before running the requested script. The value that is produced as an output is used  as an argument for the script parameter.  If both script and value are specified for a script parameter the script is executed with single argument  with value specified in the value field. The object that is produced as an output is used as an argument  for the script parameter.")
  public String getScript() {
    return script;
  }

  public void setScript(String script) {
    this.script = script;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StringScriptParameter stringScriptParameter = (StringScriptParameter) o;
    return Objects.equals(this.value, stringScriptParameter.value) &&
        Objects.equals(this.name, stringScriptParameter.name) &&
        Objects.equals(this.script, stringScriptParameter.script);
  }

  @Override
  public int hashCode() {
    return Objects.hash(value, name, script);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StringScriptParameter {\n");
    
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    script: ").append(toIndentedString(script)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
