// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the Alibaba Cloud accounts with which to share the image. You can specify up to 10 account IDs. If you specify more than 10 account IDs in a request, only the first 10 are processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<string> AddAccount { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. A dry run checks for request parameter validity and permissions. If the request is valid, the <c>DryRunOperation</c> error code is returned. Otherwise, an error is returned. If the request is valid, no fee is incurred and no resource is created. Set the value to <c>true</c> to perform a dry run. Default value: <c>false</c>.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the custom image.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>You can no longer share images that are encrypted by using a service key. You can share only images that are encrypted by using a customer managed key (CMK). If you attempt to share an image that is encrypted by using a service key, the request fails.</para>
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
        /// <item><description><para>true: publishes the image as a community image.</para>
        /// </description></item>
        /// <item><description><para>false: unpublishes the community image. The image becomes a custom image. If the image is a custom image, this setting has no effect.</para>
        /// </description></item>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
        /// <para>The region ID of the custom image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the Alibaba Cloud accounts from which to unshare the image. You can specify up to 10 account IDs. If you specify more than 10 account IDs in a request, only the first 10 are processed.</para>
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
