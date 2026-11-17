// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMarketingFlowResponseBody : TeaModel {
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
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data object returned in the response.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMarketingFlowResponseBodyData> Data { get; set; }
        public class ListMarketingFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operational activity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3243243***</para>
            /// </summary>
            [NameInMap("ActivityCode")]
            [Validation(Required=false)]
            public string ActivityCode { get; set; }

            /// <summary>
            /// <para>The operational activity description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("ActivityDesc")]
            [Validation(Required=false)]
            public string ActivityDesc { get; set; }

            /// <summary>
            /// <para>The operational activity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            /// <summary>
            /// <para>The operational activity status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("ActivityStatus")]
            [Validation(Required=false)]
            public string ActivityStatus { get; set; }

            /// <summary>
            /// <para>The business tenant code. Default value: ALICOM_OPAAS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The business extension information. Default value: {}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BizExtend")]
            [Validation(Required=false)]
            public Dictionary<string, object> BizExtend { get; set; }

            /// <summary>
            /// <para>The cron expression for the upgrade start time. For example, <c>0 0 4 1/1 * ?</c> indicates that the upgrade starts at 04:00 on the first day of each month and runs at 04:00 every day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 4 1/1 * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 XX1:11:11</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The execution method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 (default: cron)</para>
            /// </summary>
            [NameInMap("ExecutionType")]
            [Validation(Required=false)]
            public string ExecutionType { get; set; }

            /// <summary>
            /// <para>The creation time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-XX-01 11:11:11</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time. <b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <para>The operational activity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Specifies whether custom parameters are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("ParamFlag")]
            [Validation(Required=false)]
            public string ParamFlag { get; set; }

            /// <summary>
            /// <para>The custom user parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CustomerLimit&quot;:false}</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            /// <summary>
            /// <para>The code of the associated flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsafdsf***</para>
            /// </summary>
            [NameInMap("RelatedFlowCode")]
            [Validation(Required=false)]
            public string RelatedFlowCode { get; set; }

            /// <summary>
            /// <para>The name of the associated flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("RelatedFlowName")]
            [Validation(Required=false)]
            public string RelatedFlowName { get; set; }

            /// <summary>
            /// <para>The ID of the associated group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54354**</para>
            /// </summary>
            [NameInMap("RelatedGroupId")]
            [Validation(Required=false)]
            public string RelatedGroupId { get; set; }

            /// <summary>
            /// <para>The name of the associated group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAA</para>
            /// </summary>
            [NameInMap("RelatedGroupName")]
            [Validation(Required=false)]
            public string RelatedGroupName { get; set; }

            /// <summary>
            /// <para>The specific time. This parameter is valid when the execution method is set to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Specific time (when the execution method is 2)</para>
            /// </summary>
            [NameInMap("SpecificTime")]
            [Validation(Required=false)]
            public string SpecificTime { get; set; }

            /// <summary>
            /// <para>The start time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-XX 11:11:11</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The tenant code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("TenantCode")]
            [Validation(Required=false)]
            public string TenantCode { get; set; }

        }

        /// <summary>
        /// <para>The message returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB6122C9-09B5-5926-**476A96CB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.                                 </description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
