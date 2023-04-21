// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFrontVulPatchListRequest : TeaModel {
        /// <summary>
        /// The type of the action that you want to perform on the vulnerability. Valid value: vul_fix.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   cve: the Linux software vulnerability
        /// *   sys: the Windows system vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Details of the vulnerabilities. You can enter a maximum of 50 vulnerabilities.
        /// </summary>
        [NameInMap("VulInfo")]
        [Validation(Required=false)]
        public List<DescribeFrontVulPatchListRequestVulInfo> VulInfo { get; set; }
        public class DescribeFrontVulPatchListRequestVulInfo : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop that is affected by the vulnerability.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The tag that you want to add to the vulnerability.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

    }

}
