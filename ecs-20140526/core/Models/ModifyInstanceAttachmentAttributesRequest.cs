// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttachmentAttributesRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The private pool ID, which is the elasticity assurance ID or capacity reservation ID.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is required when PrivatePoolOptions.MatchCriteria is set to <c>Target</c>.</description></item>
            /// <item><description>Leave this parameter empty when PrivatePoolOptions.MatchCriteria is set to <c>Open</c> or <c>None</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool matching mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches the instance with an open private pool. If no matching private pool capacity is available, public pool resources are used to launch the instance.</description></item>
            /// <item><description>Target: targeted mode. The instance is launched by using the capacity of the specified private pool. If the specified private pool capacity is unavailable, the instance fails to be launched. If you set this parameter to Target, you must also specify the PrivatePoolOptions.Id parameter to specify the private pool ID.</description></item>
            /// <item><description>None: none. The instance is launched normally without using a private pool.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the instance for which you want to modify the private pool matching property.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4****</para>
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

        /// <summary>
        /// <para>The region ID of the private pool. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
