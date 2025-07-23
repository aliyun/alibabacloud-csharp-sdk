// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The images returned.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The ID of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-fdb897sdf****</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The time when the image was copied. Unit: milliseconds. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641275680000</para>
            /// </summary>
            [NameInMap("CopyTime")]
            [Validation(Required=false)]
            public string CopyTime { get; set; }

            /// <summary>
            /// <para>The time when the image was generated. Unit: milliseconds. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782849566738</para>
            /// </summary>
            [NameInMap("ExportTime")]
            [Validation(Required=false)]
            public long? ExportTime { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-d79x4k11pmg19****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The ID of the hardware security module (HSM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-6ja1xknf****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The image generation mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PERIODIC: It is automatically generated.</description></item>
            /// <item><description>MANUAL: It is manually generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The description of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the source backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-hodfhaol****</para>
            /// </summary>
            [NameInMap("SourceBackupUid")]
            [Validation(Required=false)]
            public string SourceBackupUid { get; set; }

            /// <summary>
            /// <para>The ID of the source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-ooopjygsn****</para>
            /// </summary>
            [NameInMap("SourceImageUid")]
            [Validation(Required=false)]
            public string SourceImageUid { get; set; }

            /// <summary>
            /// <para>The ID of the source HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-wz9i2dmefudfxtmb****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the source image resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// <para>The status of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NEW: It is disabled.</description></item>
            /// <item><description>DELETED: It is deleted.</description></item>
            /// <item><description>CREATING: It is being created.</description></item>
            /// <item><description>NORMAL: It is created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The digest of the HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3kGeHnmQzXwSsfF0Jk9eJYhe2gP6An0/HlYIiZh1****</para>
            /// </summary>
            [NameInMap("VsmDigest")]
            [Validation(Required=false)]
            public string VsmDigest { get; set; }

        }

        /// <summary>
        /// <para>The number of images per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of images returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
