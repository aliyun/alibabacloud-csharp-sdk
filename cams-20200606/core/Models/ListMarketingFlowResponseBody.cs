// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMarketingFlowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMarketingFlowResponseBodyData> Data { get; set; }
        public class ListMarketingFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3243243***</para>
            /// </summary>
            [NameInMap("ActivityCode")]
            [Validation(Required=false)]
            public string ActivityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("ActivityDesc")]
            [Validation(Required=false)]
            public string ActivityDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("ActivityStatus")]
            [Validation(Required=false)]
            public string ActivityStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BizExtend")]
            [Validation(Required=false)]
            public Dictionary<string, object> BizExtend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 4 1/1 * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01 XX1:11:11</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ExecutionType")]
            [Validation(Required=false)]
            public string ExecutionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-XX-01 11:11:11</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("ParamFlag")]
            [Validation(Required=false)]
            public string ParamFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;CustomerLimit\&quot;:false}</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsafdsf***</para>
            /// </summary>
            [NameInMap("RelatedFlowCode")]
            [Validation(Required=false)]
            public string RelatedFlowCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("RelatedFlowName")]
            [Validation(Required=false)]
            public string RelatedFlowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>54354**</para>
            /// </summary>
            [NameInMap("RelatedGroupId")]
            [Validation(Required=false)]
            public string RelatedGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AAA</para>
            /// </summary>
            [NameInMap("RelatedGroupName")]
            [Validation(Required=false)]
            public string RelatedGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("SpecificTime")]
            [Validation(Required=false)]
            public string SpecificTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-XX 11:11:11</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("TenantCode")]
            [Validation(Required=false)]
            public string TenantCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NULL</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB6122C9-09B5-5926-**476A96CB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
