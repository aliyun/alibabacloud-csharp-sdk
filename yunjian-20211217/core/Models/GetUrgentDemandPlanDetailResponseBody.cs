// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class GetUrgentDemandPlanDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>body</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUrgentDemandPlanDetailResponseBodyData Data { get; set; }
        public class GetUrgentDemandPlanDetailResponseBodyData : TeaModel {
            [NameInMap("accountDept")]
            [Validation(Required=false)]
            public string AccountDept { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1065737167271819</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>larus_prd</para>
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxx">https://xxxxx</a></para>
            /// </summary>
            [NameInMap("approvalUrl")]
            [Validation(Required=false)]
            public string ApprovalUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("bpmSubstate")]
            [Validation(Required=false)]
            public Dictionary<string, object> BpmSubstate { get; set; }

            [NameInMap("commodityTypeCodeList")]
            [Validation(Required=false)]
            public List<string> CommodityTypeCodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>262940</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>URGENT</para>
            /// </summary>
            [NameInMap("detailType")]
            [Validation(Required=false)]
            public string DetailType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-17 16:53:21</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-17 16:53:21</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>262940</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("modifierName")]
            [Validation(Required=false)]
            public string ModifierName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11223</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            [NameInMap("planName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>220</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("yunzhiProductName")]
            [Validation(Required=false)]
            public string YunzhiProductName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>msg</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e2b798516402440016572132e1459</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
