// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear private data of users. If you set AutoCleanUserdata to <c>true</c>, the custom image clears the data directories, excluding the <c>Administrator</c> and <c>Public</c> directories, in the <c>C:\\Users</c> directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCleanUserdata")]
        [Validation(Required=false)]
        public bool? AutoCleanUserdata { get; set; }

        [NameInMap("DataSnapshotIds")]
        [Validation(Required=false)]
        public List<string> DataSnapshotIds { get; set; }

        /// <summary>
        /// <para>The description of the custom image. The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-7w78ozhjcwa3u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The disk data that is contained in the custom image.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYSTEM: only contain data from system disks.</description></item>
        /// <item><description>ALL: contain data from system disks and user disks. [default]</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <para>To be hidden.</para>
        /// </summary>
        [NameInMap("ImageResourceType")]
        [Validation(Required=false)]
        public string ImageResourceType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-2zefuwk8l6ytcgd3bf4o</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The IDs of the snapshots.</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public List<string> SnapshotIds { get; set; }

    }

}
