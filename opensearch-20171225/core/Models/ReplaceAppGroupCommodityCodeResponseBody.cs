// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ReplaceAppGroupCommodityCodeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ReplaceAppGroupCommodityCodeResponseBodyResult Result { get; set; }
        public class ReplaceAppGroupCommodityCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// The billing method. Valid values:
            /// 
            /// *   POSTPAY: pay-as-you-go.
            /// *   PREPAY: subscription.
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The billing type. Valid values:
            /// 
            /// *   1: computing resources.
            /// *   2: queries per second (QPS).
            /// </summary>
            [NameInMap("chargingWay")]
            [Validation(Required=false)]
            public int? ChargingWay { get; set; }

            /// <summary>
            /// The code of the commodity.
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The timestamp when the application was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The ID of the current online version.
            /// </summary>
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The expiration time.
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// The ID of the rough sort expression.
            /// </summary>
            [NameInMap("firstRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? FirstRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// The approval state of the quotas. Valid values:
            /// 
            /// *   0: The approval status is normal.
            /// *   1: The quotas are being approved.
            /// </summary>
            [NameInMap("hasPendingQuotaReviewTask")]
            [Validation(Required=false)]
            public int? HasPendingQuotaReviewTask { get; set; }

            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The lock state. Valid values:
            /// 
            /// *   Unlock: The instance is unlocked.
            /// *   LockByExpiration: The instance is automatically locked after it expires.
            /// *   ManualLock: The instance is manually locked.
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// Indicates whether the instance is automatically locked after it expires. Valid values:
            /// 
            /// *   0: The instance is not automatically locked after it expires.
            /// *   1: The instance is automatically locked after it expires.
            /// </summary>
            [NameInMap("lockedByExpiration")]
            [Validation(Required=false)]
            public int? LockedByExpiration { get; set; }

            /// <summary>
            /// The name of the order.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the fine sort expression that is being created.
            /// </summary>
            [NameInMap("pendingSecondRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? PendingSecondRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// The ID of the order that is in progress.
            /// </summary>
            [NameInMap("processingOrderId")]
            [Validation(Required=false)]
            public string ProcessingOrderId { get; set; }

            /// <summary>
            /// Indicates whether the order is produced.
            /// </summary>
            [NameInMap("produced")]
            [Validation(Required=false)]
            public int? Produced { get; set; }

            /// <summary>
            /// The name of the A/B test group.
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public ReplaceAppGroupCommodityCodeResponseBodyResultQuota Quota { get; set; }
            public class ReplaceAppGroupCommodityCodeResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// The number of computing resources configured.
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// The storage capacity.
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// The specifications configured.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The ID of the fine sort expression.
            /// </summary>
            [NameInMap("secondRankAlgoDeploymentId")]
            [Validation(Required=false)]
            public int? SecondRankAlgoDeploymentId { get; set; }

            /// <summary>
            /// The status of the application.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The timestamp when the current online version was published.
            /// </summary>
            [NameInMap("switchedTime")]
            [Validation(Required=false)]
            public int? SwitchedTime { get; set; }

            /// <summary>
            /// The type of the application.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The timestamp when the application was updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

            /// <summary>
            /// The versions.
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

    }

}
