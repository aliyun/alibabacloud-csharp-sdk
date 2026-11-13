// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The description of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test API description</para>
        /// </summary>
        [NameInMap("ApiDescription")]
        [Validation(Required=false)]
        public string ApiDescription { get; set; }

        /// <summary>
        /// <para>The type of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: wizard API</description></item>
        /// <item><description>1: script API</description></item>
        /// <item><description>2: registered API</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ApiMode")]
        [Validation(Required=false)]
        public int? ApiMode { get; set; }

        /// <summary>
        /// <para>The name of the API. The name can contain Chinese characters, letters, digits, and underscores (_), and must start with a letter or a Chinese character. The name must be 4 to 50 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test API name</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The path of the API. The path can contain letters, digits, underscores (_), and hyphens (-), and must start with a forward slash (/). The path can be up to 200 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/1</para>
        /// </summary>
        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        /// <summary>
        /// <para>The authentication type for the cloud-native API gateway. This parameter is only valid for cloud-native groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: no authentication</description></item>
        /// <item><description>2: ApiKey</description></item>
        /// <item><description>3: JWT. When published, it is mapped to the gateway JWT, and the JWT identity is configured by the caller in the gateway.</description></item>
        /// <item><description>4: HMAC
        /// Other values are invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CloudNativeApiGwAuthType")]
        [Validation(Required=false)]
        public int? CloudNativeApiGwAuthType { get; set; }

        /// <summary>
        /// <para>The ID of the destination folder where the API is created. The ID of the root folder in a business flow is 0. The ID of a user-created folder is greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public long? FolderId { get; set; }

        /// <summary>
        /// <para>The ID of the business flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business process ID</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The protocols of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: HTTP</description></item>
        /// <item><description>1: HTTPS
        /// You can specify multiple values. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0,1</para>
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public string Protocols { get; set; }

        /// <summary>
        /// <para>The details of the registered API. For more information, see the JSON string of the registrationDetails field in the <a href="https://help.aliyun.com/document_detail/174013.html">GetDataServiceApi</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failedResultSample&quot;:&quot;fail&quot;,&quot;registrationErrorCodes&quot;:[{&quot;errorCode&quot;:&quot;e1&quot;,&quot;errorMessage&quot;:&quot;msg1&quot;,&quot;errorSolution&quot;:&quot;sol1&quot;},{&quot;errorCode&quot;:&quot;e2&quot;,&quot;errorMessage&quot;:&quot;msg2&quot;,&quot;errorSolution&quot;:&quot;sol2&quot;}],&quot;registrationRequestParameters&quot;:[{&quot;columnName&quot;:&quot;&quot;,&quot;defaultValue&quot;:&quot;&quot;,&quot;exampleValue&quot;:&quot;&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;id&quot;,&quot;parameterOperator&quot;:0,&quot;parameterPosition&quot;:1},{&quot;columnName&quot;:&quot;&quot;,&quot;defaultValue&quot;:&quot;xx&quot;,&quot;exampleValue&quot;:&quot;&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;cc&quot;,&quot;parameterOperator&quot;:2,&quot;parameterPosition&quot;:2}],&quot;serviceContentType&quot;:1,&quot;serviceHost&quot;:&quot;<a href="http://www.baidu.com%22,%22servicePath%22:%22/%5Buid%5D%22,%22serviceRequestBodyDescription%22:%22body%22,%22successfulResultSample%22:%22success%22%7D">http://www.baidu.com&quot;,&quot;servicePath&quot;:&quot;/[uid]&quot;,&quot;serviceRequestBodyDescription&quot;:&quot;body&quot;,&quot;successfulResultSample&quot;:&quot;success&quot;}</a></para>
        /// </summary>
        [NameInMap("RegistrationDetails")]
        [Validation(Required=false)]
        public string RegistrationDetails { get; set; }

        /// <summary>
        /// <para>The request data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: XML</description></item>
        /// <item><description>1: JSON</description></item>
        /// <item><description>2: form</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestContentType")]
        [Validation(Required=false)]
        public int? RequestContentType { get; set; }

        /// <summary>
        /// <para>The request method of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: GET</description></item>
        /// <item><description>1: POST</description></item>
        /// <item><description>2: PUT</description></item>
        /// <item><description>3: DELETE
        /// Wizard and script APIs support GET and POST. Registered APIs support GET, POST, PUT, and DELETE.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestMethod")]
        [Validation(Required=false)]
        public int? RequestMethod { get; set; }

        /// <summary>
        /// <para>The ID of the exclusive resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3242432423</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The response data type of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: JSON</description></item>
        /// <item><description>1: XML
        /// Wizard and script APIs support JSON. Registered APIs support JSON and XML.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public int? ResponseContentType { get; set; }

        /// <summary>
        /// <para>The details of the script API. For more information, see the JSON string of the scriptDetails field in the <a href="https://help.aliyun.com/document_detail/174013.html">GetDataServiceApi</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;isPagedResponse&quot;:false,&quot;script&quot;:&quot;select id as id1, name as name1 from person where id=${inputid}&quot;,&quot;scriptConnection&quot;:{&quot;connectionId&quot;:122786,&quot;tableName&quot;:&quot;person&quot;},&quot;scriptRequestParameters&quot;:[{&quot;defaultValue&quot;:&quot;&quot;,&quot;exampleValue&quot;:&quot;&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;inputid&quot;,&quot;parameterOperator&quot;:0,&quot;parameterPosition&quot;:1}],&quot;scriptResponseParameters&quot;:[{&quot;exampleValue&quot;:&quot;&quot;,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;id1&quot;},{&quot;exampleValue&quot;:&quot;&quot;,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;name1&quot;}]}</para>
        /// </summary>
        [NameInMap("ScriptDetails")]
        [Validation(Required=false)]
        public string ScriptDetails { get; set; }

        /// <summary>
        /// <para>The SQL mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: basic mode</description></item>
        /// <item><description>1: MyBatis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SqlMode")]
        [Validation(Required=false)]
        public long? SqlMode { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The timeout period in milliseconds. Valid values: (0, 30000].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The visibility scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: workspace</description></item>
        /// <item><description>1: private</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VisibleRange")]
        [Validation(Required=false)]
        public int? VisibleRange { get; set; }

        /// <summary>
        /// <para>The details of the wizard API. For more information, see the JSON string of the wizardDetails field in the <a href="https://help.aliyun.com/document_detail/174013.html">GetDataServiceApi</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;isPagedResponse&quot;:true,&quot;wizardConnection&quot;:{&quot;connectionId&quot;:122786,&quot;tableName&quot;:&quot;person&quot;},&quot;wizardRequestParameters&quot;:[{&quot;columnName&quot;:&quot;id&quot;,&quot;defaultValue&quot;:&quot;&quot;,&quot;exampleValue&quot;:&quot;1&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:2,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;id&quot;,&quot;parameterOperator&quot;:0,&quot;parameterPosition&quot;:0}],&quot;wizardResponseParameters&quot;:[{&quot;columnName&quot;:&quot;id&quot;,&quot;exampleValue&quot;:&quot;11&quot;,&quot;parameterDataType&quot;:2,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;id&quot;}]}</para>
        /// </summary>
        [NameInMap("WizardDetails")]
        [Validation(Required=false)]
        public string WizardDetails { get; set; }

    }

}
