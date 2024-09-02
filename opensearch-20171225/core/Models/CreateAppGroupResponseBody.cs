// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAppGroupResponseBodyResult Result { get; set; }
        public class CreateAppGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// The billing method of the application. Valid values:
            /// 
            /// *   POSTPAY: pay-as-you-go
            /// *   PREPAY: subscription
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The billing model. Valid values:
            /// 
            /// *   1: computing resources
            /// *   2: queries per second (QPS)
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
            /// The type of the industry. Valid values:
            /// 
            /// *   GENERAL: general.
            /// *   ECOMMERCE: e-commerce.
            /// *   IT_CONTENT: IT content.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// The expiration time.
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// The approval status of the quotas. Valid values:
            /// 
            /// *   0: The quotas are approved.
            /// *   1: The quotas are being approved.
            /// </summary>
            [NameInMap("hasPendingQuotaReviewTask")]
            [Validation(Required=false)]
            public int? HasPendingQuotaReviewTask { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The lock mode of the instance. Valid values:
            /// 
            /// *   Unlock: The instance is not locked.
            /// *   LockByExpiration: The instance is automatically locked after it expires.
            /// *   ManualLock: The instance is manually locked.
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the order is complete. Valid values:
            /// 
            /// *   0: The order is in progress.
            /// *   1: The order is complete.
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
            /// The information about the quotas of the application.
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public CreateAppGroupResponseBodyResultQuota Quota { get; set; }
            public class CreateAppGroupResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// The computing resources. Unit: logical computing units (LCUs).
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// The specifications of the application. Valid values:
                /// 
                /// *   opensearch.share.junior: basic
                /// *   opensearch.share.common: shared general-purpose
                /// *   opensearch.share.compute: shared computing
                /// *   opensearch.share.storage: shared storage
                /// *   opensearch.private.common: exclusive general-purpose
                /// *   opensearch.private.compute: exclusive computing
                /// *   opensearch.private.storage: exclusive storage
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The status of the application. Valid values:
            /// 
            /// *   producing
            /// *   review_pending
            /// *   config_pending
            /// *   normal
            /// *   frozen
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
            /// The type of the application. Valid values:
            /// 
            /// *   standard: a standard application.
            /// *   advance: an advanced application which is of an old application type. New applications cannot be of this type.
            /// *   enhanced: an advanced application which is of a new application type.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The timestamp when the application was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
