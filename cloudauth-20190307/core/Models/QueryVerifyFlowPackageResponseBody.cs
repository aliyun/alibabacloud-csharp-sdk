// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyFlowPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>List of returned data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<QueryVerifyFlowPackageResponseBodyItems> Items { get; set; }
        public class QueryVerifyFlowPackageResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Name of the resource package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实人认证流量包</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>Current available capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("CurrCapacity")]
            [Validation(Required=false)]
            public double? CurrCapacity { get; set; }

            /// <summary>
            /// <para>Proportion of current remaining capacity to total capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0%</para>
            /// </summary>
            [NameInMap("CurrProportion")]
            [Validation(Required=false)]
            public string CurrProportion { get; set; }

            /// <summary>
            /// <para>Details of the flow package.</para>
            /// </summary>
            [NameInMap("FlowDetails")]
            [Validation(Required=false)]
            public List<QueryVerifyFlowPackageResponseBodyItemsFlowDetails> FlowDetails { get; set; }
            public class QueryVerifyFlowPackageResponseBodyItemsFlowDetails : TeaModel {
                /// <summary>
                /// <para>Total amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public double? Capacity { get; set; }

                /// <summary>
                /// <para>Name of the flow package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>实人认证流量包</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// <para>Remaining amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("CurrCapacity")]
                [Validation(Required=false)]
                public double? CurrCapacity { get; set; }

                /// <summary>
                /// <para>Proportion of remaining amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("CurrProportion")]
                [Validation(Required=false)]
                public string CurrProportion { get; set; }

                /// <summary>
                /// <para>Expiration date.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                /// <summary>
                /// <para>Instance name</para>
                /// 
                /// <b>Example:</b>
                /// <para>tf-testacccn-hangzhouapigate84369</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Effective date.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("TakeEffectDate")]
                [Validation(Required=false)]
                public string TakeEffectDate { get; set; }

            }

            /// <summary>
            /// <para>Total quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public double? TotalCapacity { get; set; }

            /// <summary>
            /// <para>Used capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public double? UsedCapacity { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>969434DF-926B-4997-9881-4DE94E39F805</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
