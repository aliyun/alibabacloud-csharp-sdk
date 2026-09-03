// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear personal user data. If this parameter is set to <c>true</c>, the created image clears data in all directories under <c>C:\\Users</c> except the <c>Administrator</c> and <c>Public</c> directories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCleanUserdata")]
        [Validation(Required=false)]
        public bool? AutoCleanUserdata { get; set; }

        /// <summary>
        /// <para>The list of data cloud disk snapshot IDs. To include data cloud disks when creating an image, specify the corresponding data cloud disk snapshot IDs. A maximum of 100 IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;s-bp67acfmxazb4ph****&quot;, &quot;s-bp67acfmxazb5qh****&quot;]</para>
        /// </summary>
        [NameInMap("DataSnapshotIds")]
        [Validation(Required=false)]
        public List<string> DataSnapshotIds { get; set; }

        /// <summary>
        /// <para>The description of the image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cloud computer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-7w78ozhjcwa3u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The disk data included in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The image name. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deprecated</para>
        /// </summary>
        [NameInMap("ImageResourceType")]
        [Validation(Required=false)]
        public string ImageResourceType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-2zefuwk8l6ytcgd3bf4o</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The list of snapshot IDs.</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public List<string> SnapshotIds { get; set; }

    }

}
