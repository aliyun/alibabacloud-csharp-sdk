// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86_64</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens_vm</para>
        /// </summary>
        [NameInMap("ComputeType")]
        [Validation(Required=false)]
        public string ComputeType { get; set; }

        [NameInMap("DiskDeviceMapping")]
        [Validation(Required=false)]
        public List<ImportImageRequestDiskDeviceMapping> DiskDeviceMapping { get; set; }
        public class ImportImageRequestDiskDeviceMapping : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>www-cn</para>
            /// </summary>
            [NameInMap("OSSBucket")]
            [Validation(Required=false)]
            public string OSSBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>image-bucket</para>
            /// </summary>
            [NameInMap("OSSObject")]
            [Validation(Required=false)]
            public string OSSObject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("OSSRegion")]
            [Validation(Required=false)]
            public string OSSRegion { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcow2</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tmp-hybrid</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>image-test</para>
        /// </summary>
        [NameInMap("OSSObject")]
        [Validation(Required=false)]
        public string OSSObject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OSSRegion")]
        [Validation(Required=false)]
        public string OSSRegion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.8</para>
        /// </summary>
        [NameInMap("OSVersion")]
        [Validation(Required=false)]
        public string OSVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>centos</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TargetOSSRegionId")]
        [Validation(Required=false)]
        public string TargetOSSRegionId { get; set; }

    }

}
