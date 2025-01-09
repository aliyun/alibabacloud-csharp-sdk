// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetImageResponseBodyImage Image { get; set; }
        public class GetImageResponseBodyImage : TeaModel {
            /// <summary>
            /// <para>The ID of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-1618017313</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The time when the image was copied. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641275680000</para>
            /// </summary>
            [NameInMap("CopyTime")]
            [Validation(Required=false)]
            public long? CopyTime { get; set; }

            /// <summary>
            /// <para>The time when the image was generated. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786776567788</para>
            /// </summary>
            [NameInMap("ExportTime")]
            [Validation(Required=false)]
            public long? ExportTime { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-wz9c5ths5dfuwx47****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The ID of the hardware security module (HSM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-9lb32vll****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The image generation mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PERIODIC</description></item>
            /// <item><description>MANUAL</description></item>
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
            /// <para>backup-gfuiasdfa****</para>
            /// </summary>
            [NameInMap("SourceBackupUid")]
            [Validation(Required=false)]
            public string SourceBackupUid { get; set; }

            /// <summary>
            /// <para>The ID of the source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-kklhhhh****</para>
            /// </summary>
            [NameInMap("SourceImageUid")]
            [Validation(Required=false)]
            public string SourceImageUid { get; set; }

            /// <summary>
            /// <para>The ID of the source HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-wz9fnmvx190shfbk****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            /// <summary>
            /// <para>The status of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NEW</description></item>
            /// <item><description>DELETED</description></item>
            /// <item><description>CREATING</description></item>
            /// <item><description>NORMAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
