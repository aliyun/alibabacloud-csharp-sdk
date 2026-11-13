// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDataServiceApiRequest : TeaModel {
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
        /// <para>The ID of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <para>The path of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/2</para>
        /// </summary>
        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        /// <summary>
        /// <para>Optional. Only applicable to cloud-native groups. Valid values: 1 (no authentication), 2 (ApiKey), 3 (JWT, mapped to the gateway JWT upon publishing, with the JWT identity configured by the caller in the gateway), and 4 (HMAC). Other values are invalid. The same rule applies to the update operation. Including this field for a classic group causes the request to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CloudNativeApiGwAuthType")]
        [Validation(Required=false)]
        public int? CloudNativeApiGwAuthType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The API protocol. Valid values: 0 (HTTP) and 1 (HTTPS). Multiple values are supported. Separate multiple values with commas (,).</para>
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
        /// <para>The request method of the API. Valid values: 0 (GET), 1 (POST), 2 (PUT), and 3 (DELETE). Wizard and script APIs support GET and POST. Registered APIs support GET, POST, PUT, and DELETE.</para>
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
        /// <para>The response data type of the API. Valid values: 0 (JSON) and 1 (XML). Wizard and script APIs support JSON. Registered APIs support JSON and XML.</para>
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
        /// <para>The tenant ID. To obtain the tenant ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the DataStudio page, click the current username in the upper-right corner, and choose Menu &gt; User Info.</para>
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
        /// <para>The visibility scope. Valid values: 0 (workspace) and 1 (private).</para>
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
