// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class AddShardingNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account has sufficient balance.</description></item>
        /// <item><description><b>false</b>: Automatic payment is disabled. You must manually complete the payment in the console. For more information, see <a href="https://help.aliyun.com/document_detail/26352.html">Manual renewal</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The additional parameter for business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000000</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced transmission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Before the Upgrade/Downgrade, the system checks the current minor engine version of the instance. If the minor engine version is outdated, an error is returned. You must upgrade the minor engine version and retry.</description></item>
        /// <item><description><b>true</b>: Skips the check and directly executes the Upgrade/Downgrade operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of shards to add. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>The minimum total number of shards for an instance is 2. You can add up to 64 shards in a single operation, and the total number of shards for an instance cannot exceed 256. Make sure that the number of shards does not exceed this limit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The request source. This parameter is used only for internal maintenance and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The ID of a different vSwitch within the same VPC. The new data shards are created under the specified vSwitch.
        /// If you leave this parameter empty, the new data shards are created under the original vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
