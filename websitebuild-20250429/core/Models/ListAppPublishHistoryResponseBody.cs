// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppPublishHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retries are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The name of the frontend application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not used and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single query. Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The data table module. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ABTest: experiment data table</description></item>
        /// <item><description>ExperimentTool: experiment tool table</description></item>
        /// <item><description>DataDiagnosis: data diagnosis</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppPublishHistoryResponseBodyModule Module { get; set; }
        public class ListAppPublishHistoryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The ID of the current release order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CurrentPublishOrderId")]
            [Validation(Required=false)]
            public long? CurrentPublishOrderId { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the history of applying alert templates to application groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Display.</description></item>
            /// <item><description>false: Do not display. This is the default value.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<ListAppPublishHistoryResponseBodyModuleHistory> History { get; set; }
            public class ListAppPublishHistoryResponseBodyModuleHistory : TeaModel {
                /// <summary>
                /// <para>Indicates whether quick rollback is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CanQuickRevert")]
                [Validation(Required=false)]
                public string CanQuickRevert { get; set; }

                /// <summary>
                /// <para>The commit hash of the code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>890243d5977e74d80eebd4734f7b05f626f84cb1</para>
                /// </summary>
                [NameInMap("CommitHash")]
                [Validation(Required=false)]
                public string CommitHash { get; set; }

                /// <summary>
                /// <para>The current step number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE_CHECK</para>
                /// </summary>
                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public string CurrentStep { get; set; }

                /// <summary>
                /// <para>The code of the current release step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("CurrentStepCode")]
                [Validation(Required=false)]
                public string CurrentStepCode { get; set; }

                /// <summary>
                /// <para>The deployment channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PC</para>
                /// </summary>
                [NameInMap("DeployChannel")]
                [Validation(Required=false)]
                public string DeployChannel { get; set; }

                /// <summary>
                /// <para>The application description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PSKB</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The release process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("ErrorStep")]
                [Validation(Required=false)]
                public string ErrorStep { get; set; }

                /// <summary>
                /// <para>The code of the release step where the error occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BUILDING</para>
                /// </summary>
                [NameInMap("ErrorStepCode")]
                [Validation(Required=false)]
                public string ErrorStepCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is completed.</para>
                /// </summary>
                [NameInMap("IsFinish")]
                [Validation(Required=false)]
                public bool? IsFinish { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource allocation for the financial unit is successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The allocation is successful.</description></item>
                /// <item><description>false: The allocation fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The sort type. Valid values: ASC and DESC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DESC</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The code of the release order type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEPLOY</para>
                /// </summary>
                [NameInMap("OrderTypeCode")]
                [Validation(Required=false)]
                public string OrderTypeCode { get; set; }

                /// <summary>
                /// <para>The transcoding progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>The release number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PublishNumber")]
                [Validation(Required=false)]
                public string PublishNumber { get; set; }

                /// <summary>
                /// <para>The release order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PublishOrderId")]
                [Validation(Required=false)]
                public long? PublishOrderId { get; set; }

                /// <summary>
                /// <para>The release time in the UTC format yyyy-MM-dd\&quot;T\&quot;HH:mm:ss.SSS\&quot;Z\&quot;.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>The list of release step codes.</para>
                /// </summary>
                [NameInMap("StepCodes")]
                [Validation(Required=false)]
                public List<string> StepCodes { get; set; }

                /// <summary>
                /// <para>The specific configurations of the component.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<string> Steps { get; set; }

                /// <summary>
                /// <para>The release subchannel.</para>
                /// </summary>
                [NameInMap("Subchannel")]
                [Validation(Required=false)]
                public string Subchannel { get; set; }

            }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query. This parameter is empty if no next query is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
