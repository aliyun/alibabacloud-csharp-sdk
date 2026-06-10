// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppPublishHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>frontend application Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>dynamic message, not currently used. Please ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>fault parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Value range: 10 to 100. Default Value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Data Table module.  </para>
        /// <list type="bullet">
        /// <item><description><para>ABTest: experiment Data Table  </para>
        /// </description></item>
        /// <item><description><para>ExperimentTool: experiment tool table  </para>
        /// </description></item>
        /// <item><description><para>DataDiagnosis: Data Diagnosis</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppPublishHistoryResponseBodyModule Module { get; set; }
        public class ListAppPublishHistoryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Current publish order ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CurrentPublishOrderId")]
            [Validation(Required=false)]
            public long? CurrentPublishOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether to display the history of applying the alert template to application groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Display.</para>
            /// </description></item>
            /// <item><description><para>false (default): Do not display.</para>
            /// </description></item>
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

                [NameInMap("CommitHash")]
                [Validation(Required=false)]
                public string CommitHash { get; set; }

                /// <summary>
                /// <para>Current step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE_CHECK</para>
                /// </summary>
                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public string CurrentStep { get; set; }

                /// <summary>
                /// <para>Deployment channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PC</para>
                /// </summary>
                [NameInMap("DeployChannel")]
                [Validation(Required=false)]
                public string DeployChannel { get; set; }

                /// <summary>
                /// <para>Application description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PSKB</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Publishing procedure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("ErrorStep")]
                [Validation(Required=false)]
                public string ErrorStep { get; set; }

                /// <summary>
                /// <para>Indicates whether the process is complete.</para>
                /// </summary>
                [NameInMap("IsFinish")]
                [Validation(Required=false)]
                public bool? IsFinish { get; set; }

                /// <summary>
                /// <para>Indicates whether resource allocation to the cost center succeeded.</para>
                /// <list type="bullet">
                /// <item><description>true indicates success.</description></item>
                /// <item><description>false indicates failure.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

                /// <summary>
                /// <para>Error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>Sorting type: ASC or DESC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DESC</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>Transcoding progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>Publish number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PublishNumber")]
                [Validation(Required=false)]
                public string PublishNumber { get; set; }

                /// <summary>
                /// <para>Publish order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PublishOrderId")]
                [Validation(Required=false)]
                public long? PublishOrderId { get; set; }

                /// <summary>
                /// <para>Published At.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>Specific widget configuration.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<string> Steps { get; set; }

                [NameInMap("Subchannel")]
                [Validation(Required=false)]
                public string Subchannel { get; set; }

            }

            /// <summary>
            /// <para>Page number. Default value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Paging size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Token for the start of the next query. It is empty if there is no next query.</para>
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
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
