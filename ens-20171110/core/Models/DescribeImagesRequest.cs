// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-dalian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the image. You can specify only one image ID.</para>
        /// <para>Custom images and public images are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5qm2r6xo7njrpdkx04q1o****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the custom image. The name must be 2 to 128 characters in length The name must start with a letter and cannot start with <c>acs:</c> or <c>aliyun</c>. The name cannot contain <c>http://</c> or <c>https://</c>. The name can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// <para>By default, this parameter is left empty, which indicates that the original name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_6_08_64_20G_a****</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mock-clone_snapshot_id</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This parameter is not currently in use.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
