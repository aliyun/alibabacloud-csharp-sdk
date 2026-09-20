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
        /// <para>The type of the API. Valid values: 0 (wizard API), 1 (script API), and 2 (registration API).</para>
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
        /// <para>The path of the API. The path can contain letters, digits, underscores (_), and hyphens (-), and must start with a forward slash (/). The path cannot exceed 200 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/1</para>
        /// </summary>
        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        /// <summary>
        /// <para>The ID of the destination folder in which the API is created. The ID of the root folder under a business process is 0. The ID of a user-created folder is greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public long? FolderId { get; set; }

        /// <summary>
        /// <para>The ID of the business process.</para>
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
        /// <para>The protocol of the API. Valid values: 0 (HTTP) and 1 (HTTPS). Multiple values are supported. Separate multiple values with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0,1</para>
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public string Protocols { get; set; }

        /// <summary>
        /// <para>The details of the registration API. For more information, see the JSON string of the registrationDetails field in the <a href="https://help.aliyun.com/document_detail/174013.html">GetDataServiceApi</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failedResultSample&quot;:&quot;fail&quot;,&quot;registrationErrorCodes&quot;:[{&quot;errorCode&quot;:&quot;e1&quot;,&quot;errorMessage&quot;:&quot;msg1&quot;,&quot;errorSolution&quot;:&quot;sol1&quot;},{&quot;errorCode&quot;:&quot;e2&quot;,&quot;errorMessage&quot;:&quot;msg2&quot;,&quot;errorSolution&quot;:&quot;sol2&quot;}],&quot;registrationRequestParameters&quot;:[{&quot;columnName&quot;:&quot;&quot;,&quot;defaultValue&quot;:&quot;&quot;,&quot;exampleValue&quot;:&quot;&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;id&quot;,&quot;parameterOperator&quot;:0,&quot;parameterPosition&quot;:1},{&quot;columnName&quot;:&quot;&quot;,&quot;defaultValue&quot;:&quot;xx&quot;,&quot;exampleValue&quot;:&quot;&quot;,&quot;isRequiredParameter&quot;:true,&quot;parameterDataType&quot;:0,&quot;parameterDescription&quot;:&quot;&quot;,&quot;parameterName&quot;:&quot;cc&quot;,&quot;parameterOperator&quot;:2,&quot;parameterPosition&quot;:2}],&quot;serviceContentType&quot;:1,&quot;serviceHost&quot;:&quot;<a href="http://www.baidu.com%22,%22servicePath%22:%22/%5Buid%5D%22,%22serviceRequestBodyDescription%22:%22body%22,%22successfulResultSample%22:%22success%22%7D">http://www.baidu.com&quot;,&quot;servicePath&quot;:&quot;/[uid]&quot;,&quot;serviceRequestBodyDescription&quot;:&quot;body&quot;,&quot;successfulResultSample&quot;:&quot;success&quot;}</a></para>
        /// </summary>
        [NameInMap("RegistrationDetails")]
        [Validation(Required=false)]
        public string RegistrationDetails { get; set; }

        /// <summary>
        /// <para>The request content type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: XML</para>
        /// </description></item>
        /// <item><description><para>1: JSON</para>
        /// </description></item>
        /// <item><description><para>2: form</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestContentType")]
        [Validation(Required=false)]
        public int? RequestContentType { get; set; }

        /// <summary>
        /// <para>The request method of the API. Valid values: 0 (GET), 1 (POST), 2 (PUT), and 3 (DELETE). Wizard and script APIs support GET and POST. Registration APIs support GET, POST, PUT, and DELETE.</para>
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
        /// <para>The response data type of the API. Valid values: 0 (JSON) and 1 (XML). Wizard and script APIs support JSON. Registration APIs support JSON and XML.</para>
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
        /// <list type="bullet">
        /// <item><description><para>0: basic mode.</para>
        /// </description></item>
        /// <item><description><para>1: MyBatis mode.</para>
        /// </description></item>
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
        /// <para>The timeout period, in milliseconds (ms). Valid values: (0, 30000].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The visibility. Valid values: 0 (workspace) and 1 (private).</para>
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
