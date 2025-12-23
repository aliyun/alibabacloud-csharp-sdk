// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyAppGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response parameters</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyAppGroupResponseBodyResult Result { get; set; }
        public class ModifyAppGroupResponseBodyResult : TeaModel {
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
            /// <para>The billable item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: computing resources.</description></item>
            /// <item><description>2: QPS.</description></item>
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
            /// <para>1590139524</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the industry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GENERAL: general.</description></item>
            /// <item><description>ECOMMERCE: e-commerce.</description></item>
            /// <item><description>IT_CONTENT: IT content.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha3</para>
            /// </summary>
            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The time when the application expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// <para>The approval status of the quotas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: normal.</description></item>
            /// <item><description>1: being approved.</description></item>
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
            /// <para>100302881</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10030288</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock status. Valid values:</para>
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
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsh_test_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the order is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The order is in progress.</description></item>
            /// <item><description>1: The order is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("produced")]
            [Validation(Required=false)]
            public int? Produced { get; set; }

            /// <summary>
            /// <para>The name of the A/B test group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The information about the quotas of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public ModifyAppGroupResponseBodyResultQuota Quota { get; set; }
            public class ModifyAppGroupResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <para>The computing resources. Unit: logical computing unit (LCU).</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// <para>The storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// <para>The specifications. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>opensearch.share.junior: basic.</description></item>
                /// <item><description>opensearch.share.common: shared general-purpose.</description></item>
                /// <item><description>opensearch.share.compute: shared computing.</description></item>
                /// <item><description>opensearch.share.storage: shared storage.</description></item>
                /// <item><description>opensearch.private.common: exclusive general-purpose.</description></item>
                /// <item><description>opensearch.private.compute: exclusive computing.</description></item>
                /// <item><description>opensearch.private.storage: exclusive storage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch.share.common</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmoiyerh6nzly</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The state of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>producing: being produced.</description></item>
            /// <item><description>review_pending: being approved.</description></item>
            /// <item><description>config_pending: to be configured.</description></item>
            /// <item><description>normal: normal.</description></item>
            /// <item><description>frozen: frozen.</description></item>
            /// </list>
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
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: a standard edition application.</description></item>
            /// <item><description>advance: an advanced edition application of an old version. New versions are not supported for this edition.</description></item>
            /// <item><description>enhanced: an advanced edition application of a new version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enhanced</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590978265</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
