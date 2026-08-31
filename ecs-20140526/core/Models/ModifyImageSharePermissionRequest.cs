// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID to which you want to grant authorization for the shared image. Valid values of N: 1 to 10. If you submit more than 10 Alibaba Cloud accounts in a single request, the system processes only the first 10 and ignores the rest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<string> AddAccount { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the custom image to be shared.</para>
        /// <remarks>
        /// <para>Notice: Images encrypted with a service key can no longer be shared. Only images encrypted with a customer master key (CMK) can be shared. An error is returned if you attempt to share an image that is encrypted with a service key.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp18ygjuqnwhechc****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish or delist the image as a community image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Publishes the image as a community image.</description></item>
        /// <item><description>false: Delists the image to a regular image. If the image is already a regular image, no change is made.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("LaunchPermission")]
        [Validation(Required=false)]
        public string LaunchPermission { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the custom image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID from which you want to delete image sharing. Valid values of N: 1 to 10. If you submit more than 10 Alibaba Cloud accounts in a single request, the system processes only the first 10 and ignores the rest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("RemoveAccount")]
        [Validation(Required=false)]
        public List<string> RemoveAccount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
