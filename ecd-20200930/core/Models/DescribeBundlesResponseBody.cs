// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud computer templates.</para>
        /// </summary>
        [NameInMap("Bundles")]
        [Validation(Required=false)]
        public List<DescribeBundlesResponseBodyBundles> Bundles { get; set; }
        public class DescribeBundlesResponseBodyBundles : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bundle_ecd_graphics.2xlarge_s15d15_win2019</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Advanced graphics with Windows 2019</para>
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// <para>The type of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("BundleType")]
            [Validation(Required=false)]
            public string BundleType { get; set; }

            /// <summary>
            /// <para>The time when the cloud computer template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-30T06:09Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The category of the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance type of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics.2xlarge</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The details of the cloud computer instance type.</para>
            /// </summary>
            [NameInMap("DesktopTypeAttribute")]
            [Validation(Required=false)]
            public DescribeBundlesResponseBodyBundlesDesktopTypeAttribute DesktopTypeAttribute { get; set; }
            public class DescribeBundlesResponseBodyBundlesDesktopTypeAttribute : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("GpuCount")]
                [Validation(Required=false)]
                public float? GpuCount { get; set; }

                /// <summary>
                /// <para>The GPU type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NVIDIA T4</para>
                /// </summary>
                [NameInMap("GpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

            /// <summary>
            /// <para>The instance family of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.general</para>
            /// </summary>
            [NameInMap("DesktopTypeFamily")]
            [Validation(Required=false)]
            public string DesktopTypeFamily { get; set; }

            /// <summary>
            /// <para>Details of the disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeBundlesResponseBodyBundlesDisks> Disks { get; set; }
            public class DescribeBundlesResponseBodyBundlesDisks : TeaModel {
                /// <summary>
                /// <para>The PL of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("DiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DiskPerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The type of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktopimage-windows-server-2019-64-ch-vgpu</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows server 2019 Chinese</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The status of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("ImageStatus")]
            [Validation(Required=false)]
            public string ImageStatus { get; set; }

            /// <summary>
            /// <para>The OS language of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en-US</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The type of the OS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The OS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Server 2019</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The inventory status of the cloud computer instance type. This parameter is returned only if you set the <c>CheckStock</c> parameter to <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sufficient</para>
            /// </summary>
            [NameInMap("StockState")]
            [Validation(Required=false)]
            public string StockState { get; set; }

            /// <summary>
            /// <para>The category of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>Indicates whether disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <para>The token that is used for the next query. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lu3PTF6h3zE8egwlYuv8M8</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCC854D8-5D1E-46D3-96EF-797A5DD36789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
