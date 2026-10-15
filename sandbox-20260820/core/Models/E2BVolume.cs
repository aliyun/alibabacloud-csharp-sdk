// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BVolume : TeaModel {
        /// <summary>
        /// <para>The AgenticBucket volume configuration.</para>
        /// </summary>
        [NameInMap("agenticBucketVolumeConfig")]
        [Validation(Required=false)]
        public AgenticBucketVolumeConfig AgenticBucketVolumeConfig { get; set; }

        /// <summary>
        /// <para>The AgenticFS volume configuration.</para>
        /// </summary>
        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public AgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }

        /// <summary>
        /// <para>The time when the volume was created, in UTC. The time is in the yyyy-MM-ddTHH:mm:ss.SSSSSSZ format, with exactly 6 decimal places for fractional seconds (microsecond precision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-07T02:12:36.531000Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The JuiceFS volume configuration.</para>
        /// </summary>
        [NameInMap("juiceFSVolumeConfig")]
        [Validation(Required=false)]
        public JuiceFSVolumeConfig JuiceFSVolumeConfig { get; set; }

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public VolumeMountConfig MountConfig { get; set; }

        /// <summary>
        /// <para>The OSS volume configuration.</para>
        /// </summary>
        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-****</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The volume status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS</description></item>
        /// <item><description>AGENTIC_FS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f5a1fe9-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The time when the volume was last updated, in UTC. The time is in the yyyy-MM-ddTHH:mm:ss.SSSSSSZ format, with exactly 6 decimal places for fractional seconds (microsecond precision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-07T03:48:05.274000Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000****</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25878d34-****</para>
        /// </summary>
        [NameInMap("volumeID")]
        [Validation(Required=false)]
        public string VolumeID { get; set; }

        /// <summary>
        /// <para>The name, which is unique within the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace</para>
        /// </summary>
        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
