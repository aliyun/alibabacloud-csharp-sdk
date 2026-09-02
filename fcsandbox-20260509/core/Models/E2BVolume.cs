// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BVolume : TeaModel {
        /// <summary>
        /// <para>The AgenticFS configuration.</para>
        /// </summary>
        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public AgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }

        /// <summary>
        /// <para>The time when the volume was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-10T11:05:55Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public E2BVolumeMountConfig MountConfig { get; set; }
        public class E2BVolumeMountConfig : TeaModel {
            /// <summary>
            /// <para>The RAM role that the user grants to the sandboxed container. After this role is set, the sandboxed container assumes the role to generate temporary access credentials. You can use the temporary access credentials of this role to mount storage in the sandboxed container, such as OSS and AgenticFS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1673427197867277:role/aliyunfcdefaultrole</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// </summary>
            [NameInMap("vpcConfig")]
            [Validation(Required=false)]
            public E2BVolumeMountConfigVpcConfig VpcConfig { get; set; }
            public class E2BVolumeMountConfigVpcConfig : TeaModel {
                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The list of vSwitches.</para>
                /// </summary>
                [NameInMap("vSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze4l2vyhej6a6dwapm4q</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The OSS configuration.</para>
        /// </summary>
        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwxqyrgwabcd</para>
        /// </summary>
        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATING</description></item>
        /// <item><description>AVAILABLE</description></item>
        /// <item><description>ERROR</description></item>
        /// <item><description>DELETING</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
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
        /// <para>88a4c762-b0ce-4661-9413-578b2309e60f</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The time when the volume was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-10T11:05:55Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2190856988355929</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82c8c42e-cf7a-46d0-8b58-9024409c1579</para>
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
