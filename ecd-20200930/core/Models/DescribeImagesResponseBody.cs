// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagesResponseBody : TeaModel {
        /// <summary>
        /// The details of the images.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<DescribeImagesResponseBodyImages> Images { get; set; }
        public class DescribeImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// The version of the image.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// The time when the image was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GiB.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// The description of the image.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the image is a GPU-accelerated image.
            /// </summary>
            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public bool? GpuCategory { get; set; }

            /// <summary>
            /// The version number of the GPU driver.
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of the image.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CUSTOM
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the operating system.
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The operating system type of the image.
            /// 
            /// Valid values:
            /// 
            /// *   Ubuntu
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows Server 2022
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   UOS
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CentOS
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows Server 2019
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   SQL Server 2016
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows 10
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The creation progress of the image. Unit: %.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The protocol type.
            /// 
            /// Valid values:
            /// 
            /// *   HDX: High-definition Experience (HDX) protocol
            /// *   ASP: in-house Adaptive Streaming Protocol (ASP) (recommended)
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The type of the image session.
            /// 
            /// Valid values:
            /// 
            /// *   SINGLE_SESSION: single-session image.
            /// 
            /// *   MULTIPLE_SESSION: multi-session image.
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// The number of shared images.
            /// </summary>
            [NameInMap("SharedCount")]
            [Validation(Required=false)]
            public int? SharedCount { get; set; }

            /// <summary>
            /// The size of the image. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The status of the image.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Available
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CreateFailed
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The languages of the operating system.
            /// </summary>
            [NameInMap("SupportedLanguages")]
            [Validation(Required=false)]
            public List<string> SupportedLanguages { get; set; }

            /// <summary>
            /// The time when the image was last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// Indicates whether disk encryption is enabled.
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled. You can call the [ListKeys](~~28951~~) operation to query the list of KMS keys.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// The token that determines the start point of the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
