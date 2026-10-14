// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>The system architecture. Valid values:</br></para>
        /// <list type="bullet">
        /// <item><description>x86_64</description></item>
        /// </list>
        /// <para>Currently, only x86_64 is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86_64</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <para>ens_vm: ENS virtual machine image (default).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens_vm</para>
        /// </summary>
        [NameInMap("ComputeType")]
        [Validation(Required=false)]
        public string ComputeType { get; set; }

        /// <summary>
        /// <para>The list of custom image information.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <para>The OSS bucket that stores the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>www-cn</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <para>The file name (key) of the image file stored in the OSS bucket after the image is uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-bucket</para>
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

            /// <summary>
            /// <para>The region where the image resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("OSSRegion")]
            [Validation(Required=false)]
            public string OSSRegion { get; set; }

        }

        /// <summary>
        /// <para>The image format. Valid values:</br>
        /// qcow2.</br>
        /// Currently, only qcow2 is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcow2</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// <para>The image name. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with http:// or https://.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The image license type. Valid values: Aliyun (Alibaba Cloud license) and BYOL (Bring Your Own Key).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The OSS bucket that stores the image file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmp-hybrid</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <para>The name of the image file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-test</para>
        /// </summary>
        [NameInMap("OSSObject")]
        [Validation(Required=false)]
        public string OSSObject { get; set; }

        /// <summary>
        /// <para>The region where the image resides. Currently, only cn-beijing is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OSSRegion")]
        [Validation(Required=false)]
        public string OSSRegion { get; set; }

        /// <summary>
        /// <para>The type of the operating system platform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows</description></item>
        /// <item><description>linux</description></item>
        /// </list>
        /// <para>Currently, only linux is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The version of the operating system distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.8</para>
        /// </summary>
        [NameInMap("OSVersion")]
        [Validation(Required=false)]
        public string OSVersion { get; set; }

        /// <summary>
        /// <para>The operating system distribution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>centos</description></item>
        /// <item><description>ubuntu</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>centos</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region of the destination OSS bucket where the image is stored.</br></para>
        /// <remarks>
        /// <para>Currently, only cn-beijing and ap-southeast-1 are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TargetOSSRegionId")]
        [Validation(Required=false)]
        public string TargetOSSRegionId { get; set; }

    }

}
