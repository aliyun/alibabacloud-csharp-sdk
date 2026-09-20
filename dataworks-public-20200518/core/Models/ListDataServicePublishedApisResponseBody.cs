// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServicePublishedApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The published API information returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServicePublishedApisResponseBodyData Data { get; set; }
        public class ListDataServicePublishedApisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of published API information.</para>
            /// </summary>
            [NameInMap("Apis")]
            [Validation(Required=false)]
            public List<ListDataServicePublishedApisResponseBodyDataApis> Apis { get; set; }
            public class ListDataServicePublishedApisResponseBodyDataApis : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10002</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>The type of the API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: wizard API.</description></item>
                /// <item><description>1: script API.</description></item>
                /// <item><description>2: registration API.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ApiMode")]
                [Validation(Required=false)]
                public int? ApiMode { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My API name</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/1</para>
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// <para>The time when the API was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test API description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ab123</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The time when the API was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud ID of the user who last edited the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2345678</para>
                /// </summary>
                [NameInMap("OperatorId")]
                [Validation(Required=false)]
                public string OperatorId { get; set; }

                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The API protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: HTTP.</description></item>
                /// <item><description>1: HTTPS.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public List<int?> Protocols { get; set; }

                /// <summary>
                /// <para>The details of the registration API. This is returned only for registration APIs.</para>
                /// </summary>
                [NameInMap("RegistrationDetails")]
                [Validation(Required=false)]
                public ListDataServicePublishedApisResponseBodyDataApisRegistrationDetails RegistrationDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetails : TeaModel {
                    /// <summary>
                    /// <para>The sample of an error response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: false}</para>
                    /// </summary>
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    /// <summary>
                    /// <para>The list of error codes for the registration API.</para>
                    /// </summary>
                    [NameInMap("RegistrationErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes> RegistrationErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes : TeaModel {
                        /// <summary>
                        /// <para>The error code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1001</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fail to call</para>
                        /// </summary>
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        /// <summary>
                        /// <para>The fault Solutions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>retry</para>
                        /// </summary>
                        [NameInMap("ErrorSolution")]
                        [Validation(Required=false)]
                        public string ErrorSolution { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of request parameters for the registration API.</para>
                    /// </summary>
                    [NameInMap("RegistrationRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters> RegistrationRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters : TeaModel {
                        /// <summary>
                        /// <para>The default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default1</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <para>The example value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example1</para>
                        /// </summary>
                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        /// <summary>
                        /// <para>The data type. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>description1</para>
                        /// </summary>
                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name1</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// <para>The operator. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        /// <summary>
                        /// <para>The parameter position. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    /// <summary>
                    /// <para>The return data type of the API. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: JSON.</description></item>
                    /// <item><description>1: XML.</description></item>
                    /// </list>
                    /// <para>Wizard and script APIs support JSON. Registration APIs support JSON and XML.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ServiceContentType")]
                    [Validation(Required=false)]
                    public int? ServiceContentType { get; set; }

                    /// <summary>
                    /// <para>The backend service address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.abc.com">http://www.abc.com</a></para>
                    /// </summary>
                    [NameInMap("ServiceHost")]
                    [Validation(Required=false)]
                    public string ServiceHost { get; set; }

                    /// <summary>
                    /// <para>The backend service path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/index</para>
                    /// </summary>
                    [NameInMap("ServicePath")]
                    [Validation(Required=false)]
                    public string ServicePath { get; set; }

                    /// <summary>
                    /// <para>The description of the backend request body content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;abc&quot;:1}</para>
                    /// </summary>
                    [NameInMap("ServiceRequestBodyDescription")]
                    [Validation(Required=false)]
                    public string ServiceRequestBodyDescription { get; set; }

                    /// <summary>
                    /// <para>The sample of a successful response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: true}</para>
                    /// </summary>
                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                }

                /// <summary>
                /// <para>The request method of the API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: GET.</description></item>
                /// <item><description>1: POST.</description></item>
                /// <item><description>2: PUT.</description></item>
                /// <item><description>3: DELETE.</description></item>
                /// </list>
                /// <para>Wizard and script APIs support GET and POST. Registration APIs support GET, POST, PUT, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RequestMethod")]
                [Validation(Required=false)]
                public int? RequestMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResponseContentType")]
                [Validation(Required=false)]
                public int? ResponseContentType { get; set; }

                /// <summary>
                /// <para>The details of the script API. This is returned only for script APIs.</para>
                /// </summary>
                [NameInMap("ScriptDetails")]
                [Validation(Required=false)]
                public ListDataServicePublishedApisResponseBodyDataApisScriptDetails ScriptDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisScriptDetails : TeaModel {
                    /// <summary>
                    /// <para>The sample of an error response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: false}</para>
                    /// </summary>
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the response is paginated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    /// <summary>
                    /// <para>The SQL script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select a from t</para>
                    /// </summary>
                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    /// <summary>
                    /// <para>The data source information for the script API.</para>
                    /// </summary>
                    [NameInMap("ScriptConnection")]
                    [Validation(Required=false)]
                    public ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptConnection ScriptConnection { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptConnection : TeaModel {
                        /// <summary>
                        /// <para>The data source ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }

                        /// <summary>
                        /// <para>The table name of the data source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>t</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of error codes for the script API.</para>
                    /// </summary>
                    [NameInMap("ScriptErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptErrorCodes> ScriptErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptErrorCodes : TeaModel {
                        /// <summary>
                        /// <para>The error code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1001</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fail to call</para>
                        /// </summary>
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        /// <summary>
                        /// <para>The fault Solutions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>retry</para>
                        /// </summary>
                        [NameInMap("ErrorSolution")]
                        [Validation(Required=false)]
                        public string ErrorSolution { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of request parameters for the script API.</para>
                    /// </summary>
                    [NameInMap("ScriptRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptRequestParameters> ScriptRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptRequestParameters : TeaModel {
                        /// <summary>
                        /// <para>The default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default1</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <para>The example value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example1</para>
                        /// </summary>
                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        /// <summary>
                        /// <para>The data type. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>description1</para>
                        /// </summary>
                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// <para>The operator. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        /// <summary>
                        /// <para>The parameter position. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of response parameters for the script API.</para>
                    /// </summary>
                    [NameInMap("ScriptResponseParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptResponseParameters> ScriptResponseParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptResponseParameters : TeaModel {
                        /// <summary>
                        /// <para>The example value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example2</para>
                        /// </summary>
                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        /// <summary>
                        /// <para>The data type. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>description2</para>
                        /// </summary>
                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param2</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                    }

                    /// <summary>
                    /// <para>The sample of a successful response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: true}</para>
                    /// </summary>
                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                }

                /// <summary>
                /// <para>The SQL mode. Valid values: 0 (basic SQL) and 1 (advanced SQL).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SqlMode")]
                [Validation(Required=false)]
                public int? SqlMode { get; set; }

                /// <summary>
                /// <para>The status of the API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: unpublished.</description></item>
                /// <item><description>1: published.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
                /// <para>The timeout period, in milliseconds (ms).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The visibility range. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: workspace.</description></item>
                /// <item><description>1: private.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VisibleRange")]
                [Validation(Required=false)]
                public int? VisibleRange { get; set; }

                /// <summary>
                /// <para>The details of the wizard API. This is returned only for wizard APIs.</para>
                /// </summary>
                [NameInMap("WizardDetails")]
                [Validation(Required=false)]
                public ListDataServicePublishedApisResponseBodyDataApisWizardDetails WizardDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisWizardDetails : TeaModel {
                    /// <summary>
                    /// <para>The sample of an error response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: false}</para>
                    /// </summary>
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the response is paginated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    /// <summary>
                    /// <para>The sample of a successful response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;success&quot;: true}</para>
                    /// </summary>
                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                    /// <summary>
                    /// <para>The data source information of the wizard API.</para>
                    /// </summary>
                    [NameInMap("WizardConnection")]
                    [Validation(Required=false)]
                    public ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardConnection WizardConnection { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardConnection : TeaModel {
                        /// <summary>
                        /// <para>The data source ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12354</para>
                        /// </summary>
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }

                        /// <summary>
                        /// <para>The table name of the data source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>t</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of error codes for the wizard API.</para>
                    /// </summary>
                    [NameInMap("WizardErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardErrorCodes> WizardErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardErrorCodes : TeaModel {
                        /// <summary>
                        /// <para>The error code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1001</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fail to call</para>
                        /// </summary>
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        /// <summary>
                        /// <para>The fault Solutions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>retry</para>
                        /// </summary>
                        [NameInMap("ErrorSolution")]
                        [Validation(Required=false)]
                        public string ErrorSolution { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of request parameters for the wizard API.</para>
                    /// </summary>
                    [NameInMap("WizardRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardRequestParameters> WizardRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardRequestParameters : TeaModel {
                        /// <summary>
                        /// <para>The default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default1</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <para>The example value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example1</para>
                        /// </summary>
                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        /// <summary>
                        /// <para>The data type. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>description1</para>
                        /// </summary>
                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        /// <summary>
                        /// <para>The name of the parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        /// <summary>
                        /// <para>The operator. Valid values: 0 (Equal), 1 (Like), 2 (Const), and 3 (In). Wizard mode APIs support Equal, Like, and In. Script mode APIs support Equal. Registered APIs support Equal and Const.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        /// <summary>
                        /// <para>The position of the parameter. Valid values: 0 (Path), 1 (Query), 2 (Head), and 3 (Body). Wizard and script APIs support only Query. For registered APIs, the GET and DELETE methods support Query and Head, and the PUT and POST methods support Query, Head, and Body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of response parameters for the wizard API.</para>
                    /// </summary>
                    [NameInMap("WizardResponseParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardResponseParameters> WizardResponseParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardResponseParameters : TeaModel {
                        /// <summary>
                        /// <para>The example value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example2</para>
                        /// </summary>
                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        /// <summary>
                        /// <para>The data type. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>description2</para>
                        /// </summary>
                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        /// <summary>
                        /// <para>The name of the parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param2</para>
                        /// </summary>
                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The page number, which is consistent with the PageNumber in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID, which is the unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
