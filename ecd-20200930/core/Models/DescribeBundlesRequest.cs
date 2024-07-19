// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud computer templates. You can specify 1 to 100 IDs.
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public List<string> BundleId { get; set; }

        /// <summary>
        /// The type of the cloud computer template.
        /// 
        /// Valid values:
        /// 
        /// *   SYSTEM: system template
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CUSTOM: custom template
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("BundleType")]
        [Validation(Required=false)]
        public string BundleType { get; set; }

        /// <summary>
        /// Specifies whether to query the inventory status of the cloud computer instance type.
        /// </summary>
        [NameInMap("CheckStock")]
        [Validation(Required=false)]
        public bool? CheckStock { get; set; }

        /// <summary>
        /// The number of vCPUs contained in the cloud computer instance type.
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// The instance family of the cloud computers.
        /// 
        /// Valid values:
        /// 
        /// *   eds.graphics: graphical instance families
        /// *   eds.hf: instance families with high clock speeds
        /// *   eds.general: general-purpose instance families
        /// </summary>
        [NameInMap("DesktopTypeFamily")]
        [Validation(Required=false)]
        public string DesktopTypeFamily { get; set; }

        /// <summary>
        /// This parameter is now in invitational preview and not publicly available.
        /// </summary>
        [NameInMap("FotaChannel")]
        [Validation(Required=false)]
        public string FotaChannel { get; set; }

        /// <summary>
        /// Specifies whether the cloud computers in the template belong to a cloud computer pool.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("FromDesktopGroup")]
        [Validation(Required=false)]
        public bool? FromDesktopGroup { get; set; }

        /// <summary>
        /// The number of GPUs contained in the cloud computer instance type.
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// The image ID.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The memory size of the cloud computer instance type. Unit: GiB.
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The type of the OS.
        /// 
        /// Valid values:
        /// 
        /// *   Linux
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   Windows
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// The protocol type.
        /// 
        /// Valid values:
        /// 
        /// *   HDX: High-definition Experience (HDX) protocol
        /// *   ASP: in-house Adaptive Streaming Protocol (ASP) (recommend)
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The scenario to use the image.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The desktop template that is selected based on specific criteria.
        /// </summary>
        [NameInMap("SelectedBundle")]
        [Validation(Required=false)]
        public bool? SelectedBundle { get; set; }

        /// <summary>
        /// The type of the session.
        /// 
        /// Enumeration Value:
        /// * **SingleSession**
        /// * **MultipleSession**
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// Specifies whether to return multi-session cloud computer templates. Default value: false.
        /// </summary>
        [NameInMap("SupportMultiSession")]
        [Validation(Required=false)]
        public bool? SupportMultiSession { get; set; }

        /// <summary>
        /// Specifies whether to enable disk encryption.
        /// </summary>
        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

    }

}
