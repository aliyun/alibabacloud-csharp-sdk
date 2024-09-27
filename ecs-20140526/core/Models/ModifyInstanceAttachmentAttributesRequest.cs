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
            /// <para>The ID of the private pool. Set the value to the ID of the elasticity assurance or capacity reservation that generates the private pool.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is required when <c>PrivatePoolOptions.MatchCriteria</c> is set to <c>Target</c>.</description></item>
            /// <item><description>This parameter must be empty when <c>PrivatePoolOptions.MatchCriteria</c> is set to <c>Open</c> or <c>None</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The match mode of the private pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open private pool. The system matches the instance with open private pools.</description></item>
            /// <item><description>Target: specified private pool. You must set the <c>PrivatePoolOptions.Id</c> parameter to specify the ID of a private pool.</description></item>
            /// <item><description>None: no private pool. The instance starts normally without using private pools.</description></item>
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
        /// <para>The ID of the instance for which you want to modify the attributes of the private pool.</para>
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
        /// <para>The region ID of the private pool. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
