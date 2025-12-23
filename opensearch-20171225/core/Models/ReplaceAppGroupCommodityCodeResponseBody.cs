// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ReplaceAppGroupCommodityCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC5F78BA-66B9-545B-9CF1-8F542E682E1F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ReplaceAppGroupCommodityCodeResponseBodyResult Result { get; set; }
        public class ReplaceAppGroupCommodityCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>POSTPAY: pay-as-you-go.</description></item>
            /// <item><description>PREPAY: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: computing resources.</description></item>
            /// <item><description>2: queries per second (QPS).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("chargingWay")]
            [Validation(Required=false)]
            public int? ChargingWay { get; set; }

            /// <summary>
            /// <para>The code of the commodity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588054131</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the current online version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100302903</para>
            /// </summary>
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// <para>The ID of the rough sort expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("firstRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? FirstRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// <para>The approval state of the quotas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The approval status is normal.</description></item>
            /// <item><description>1: The quotas are being approved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("hasPendingQuotaReviewTask")]
            [Validation(Required=false)]
            public int? HasPendingQuotaReviewTask { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Unlock: The instance is unlocked.</description></item>
            /// <item><description>LockByExpiration: The instance is automatically locked after it expires.</description></item>
            /// <item><description>ManualLock: The instance is manually locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is automatically locked after it expires. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The instance is not automatically locked after it expires.</description></item>
            /// <item><description>1: The instance is automatically locked after it expires.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lockedByExpiration")]
            [Validation(Required=false)]
            public int? LockedByExpiration { get; set; }

            /// <summary>
            /// <para>The name of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the fine sort expression that is being created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pendingSecondRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? PendingSecondRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// <para>The ID of the order that is in progress.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("processingOrderId")]
            [Validation(Required=false)]
            public string ProcessingOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the order is produced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("produced")]
            [Validation(Required=false)]
            public int? Produced { get; set; }

            /// <summary>
            /// <para>The name of the A/B test group.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public ReplaceAppGroupCommodityCodeResponseBodyResultQuota Quota { get; set; }
            public class ReplaceAppGroupCommodityCodeResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <para>The number of computing resources configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// <para>The storage capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// <para>The specifications configured.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The ID of the fine sort expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("secondRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? SecondRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// <para>The status of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The timestamp when the current online version was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590486386</para>
            /// </summary>
            [NameInMap("switchedTime")]
            [Validation(Required=false)]
            public int? SwitchedTime { get; set; }

            /// <summary>
            /// <para>The type of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1581065904</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// <para>The versions.</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

    }

}
