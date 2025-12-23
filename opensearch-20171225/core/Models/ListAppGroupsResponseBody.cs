// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListAppGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the application.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/170000.html">AppGroup</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAppGroupsResponseBodyResult> Result { get; set; }
        public class ListAppGroupsResponseBodyResult : TeaModel {
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
            /// <para>The commodity code.</para>
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
            /// <para>1575442875</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the current online version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110116134</para>
            /// </summary>
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;xxx&quot;</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The industry of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
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
            /// <para>&quot;xxx&quot;</para>
            /// </summary>
            [NameInMap("expireOn")]
            [Validation(Required=false)]
            public string ExpireOn { get; set; }

            /// <summary>
            /// <para>The approval state of the quotas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The application is in service.</description></item>
            /// <item><description>1: The quotas are being reviewed.</description></item>
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
            /// <para>110116134</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;xxx&quot;</para>
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
            /// <para>Indicates whether the instance is automatically locked after it expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lockedByExpiration")]
            [Validation(Required=false)]
            public int? LockedByExpiration { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_function_test_v1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The application is being created.</description></item>
            /// <item><description>1: The application is created.</description></item>
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
            /// <para>&quot;xxx&quot;</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The information about the quotas of the application. For more information, see <a href="https://help.aliyun.com/document_detail/170001.html">Quota</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public ListAppGroupsResponseBodyResultQuota Quota { get; set; }
            public class ListAppGroupsResponseBodyResultQuota : TeaModel {
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
            /// <para>The state of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>producing: The application is being created.</description></item>
            /// <item><description>review_pending: The application is being reviewed.</description></item>
            /// <item><description>config_pending: The application is to be configured.</description></item>
            /// <item><description>normal: The application is in service.</description></item>
            /// <item><description>frozen: The application is frozen.</description></item>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("switchedTime")]
            [Validation(Required=false)]
            public int? SwitchedTime { get; set; }

            /// <summary>
            /// <para>The application tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListAppGroupsResponseBodyResultTags> Tags { get; set; }
            public class ListAppGroupsResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>foo</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bar</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: a High-performance Search Edition application.</description></item>
            /// <item><description>enhanced: an Industry Algorithm Edition application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enhanced</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The timestamp when the application was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578916076</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
