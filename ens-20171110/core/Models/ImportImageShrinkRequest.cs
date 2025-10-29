// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>System architecture. Allowed values:</br></para>
        /// <list type="bullet">
        /// <item><description>x86_64.</br></description></item>
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
        /// <para><c>Image Type</c>
        /// ens_vm: ens virtual machine image (default)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens_vm</para>
        /// </summary>
        [NameInMap("ComputeType")]
        [Validation(Required=false)]
        public string ComputeType { get; set; }

        /// <summary>
        /// <para>List of custom image information being created.</para>
        /// </summary>
        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public string DiskDeviceMappingShrink { get; set; }

        /// <summary>
        /// <para>Image format. Allowed values:</br>
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
        /// <para>Image name. The length should be [2, 128] English or Chinese characters. It must start with a letter (uppercase or lowercase) or a Chinese character, and cannot start with http:// or https://. It can contain numbers, colons (:), underscores (_), or hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>镜像名称</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The OSS Bucket where the image file is located.</para>
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
        /// <para>The Region where the image is located. Currently, only cn-beijing is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OSSRegion")]
        [Validation(Required=false)]
        public string OSSRegion { get; set; }

        /// <summary>
        /// <para>Operating system platform type. Allowed values:</para>
        /// <list type="bullet">
        /// <item><description>windows.</description></item>
        /// <item><description>linux.</description></item>
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
        /// <para>Operating system distribution version</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.8</para>
        /// </summary>
        [NameInMap("OSVersion")]
        [Validation(Required=false)]
        public string OSVersion { get; set; }

        /// <summary>
        /// <para>Operating system distribution. Allowed values:</para>
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
        /// <para>The target OSS region where the image will be stored.</br></para>
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
