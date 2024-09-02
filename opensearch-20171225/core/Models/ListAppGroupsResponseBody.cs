// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListAppGroupsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the application.
        /// 
        /// For more information, see [AppGroup](https://help.aliyun.com/document_detail/170000.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAppGroupsResponseBodyResult> Result { get; set; }
        public class ListAppGroupsResponseBodyResult : TeaModel {
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
            /// The billable item. Valid values:
            /// 
            /// *   1: computing resources.
            /// *   2: queries per second (QPS).
            /// </summary>
            [NameInMap("chargingWay")]
            [Validation(Required=false)]
            public int? ChargingWay { get; set; }

            /// <summary>
            /// The commodity code.
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
            /// The industry of the application.
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// The time when the application expired.
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// The approval state of the quotas. Valid values:
            /// 
            /// *   0: The application is in service.
            /// *   1: The quotas are being reviewed.
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
            /// Indicates whether the instance is automatically locked after it expires.
            /// </summary>
            [NameInMap("lockedByExpiration")]
            [Validation(Required=false)]
            public int? LockedByExpiration { get; set; }

            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the application is created. Valid values:
            /// 
            /// *   0: The application is being created.
            /// *   1: The application is created.
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
            /// The information about the quotas of the application. For more information, see [Quota](https://help.aliyun.com/document_detail/170001.html).
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public ListAppGroupsResponseBodyResultQuota Quota { get; set; }
            public class ListAppGroupsResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// The computing resources. Unit: logical computing unit (LCU).
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
                /// The specifications. Valid values:
                /// 
                /// *   opensearch.share.junior: basic.
                /// *   opensearch.share.common: shared general-purpose.
                /// *   opensearch.share.compute: shared computing.
                /// *   opensearch.share.storage: shared storage.
                /// *   opensearch.private.common: exclusive general-purpose.
                /// *   opensearch.private.compute: exclusive computing.
                /// *   opensearch.private.storage: exclusive storage.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The state of the application. Valid values:
            /// 
            /// *   producing: The application is being created.
            /// *   review_pending: The application is being reviewed.
            /// *   config_pending: The application is to be configured.
            /// *   normal: The application is in service.
            /// *   frozen: The application is frozen.
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
            /// The application tags.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListAppGroupsResponseBodyResultTags> Tags { get; set; }
            public class ListAppGroupsResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the application. Valid values:
            /// 
            /// *   standard: a High-performance Search Edition application.
            /// *
            /// *   enhanced: an Industry Algorithm Edition application.
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

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
