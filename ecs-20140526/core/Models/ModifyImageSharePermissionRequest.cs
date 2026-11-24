// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID for shared image authorization. Valid values of N: 1 to 10. If you commit more than 10 Alibaba Cloud account IDs at a time, the system processes only the first 10 account IDs and ignores the rest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<string> AddAccount { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a precheck request without modifying the image sharing permissions. If the check passes, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: sends a regular request and modifies the image sharing permissions if the check passes.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the custom image to be shared.</para>
        /// <remarks>
        /// <para>Notice: Images with service key encryption can no longer be shared. Only images encrypted by using a customer master key (CMK) can be shared. An error is reported if you attempt to share an image with service key encryption.</para>
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
        /// <para>Specifies whether to publish or unpublish the community image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: publishes the image as a community image.</description></item>
        /// <item><description>false: unpublishes the image and changes it to a regular image. If the image is already a regular image, no changes are made.</description></item>
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
        /// <para>This parameter is in invitational preview and is not supported.</para>
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
        /// <para>The region ID of the custom image. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to delete from image sharing. Valid values of N: 1 to 10. If you commit more than 10 Alibaba Cloud account IDs at a time, the system processes only the first 10 account IDs and ignores the rest.</para>
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
