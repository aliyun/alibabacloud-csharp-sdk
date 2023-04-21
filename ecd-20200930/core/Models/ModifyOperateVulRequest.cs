// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOperateVulRequest : TeaModel {
        /// <summary>
        /// The action that you want to perform on the vulnerability. Valid values:
        /// 
        /// *   vul_fix: fixes the vulnerability. The system fixes the vulnerability.
        /// *   vul_verify: verifies whether the vulnerability is fixed. You must perform this action after the vulnerability is fixed, and the cloud desktop is restarted.
        /// *   vul_ignore: ignores the vulnerability. After the vulnerability is ignored, the system provides no more prompts about the vulnerability.
        /// *   vul_undo_ignore: cancels the ignore action on the vulnerability. After you cancel the ignore action on the vulnerability, the system provides prompts about the vulnerability again.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The reason why the vulnerability is ignored.\
        /// This parameter is required only when `OperateType` is set to `vul_ignore`.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

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
        /// Details of the vulnerabilities.
        /// </summary>
        [NameInMap("VulInfo")]
        [Validation(Required=false)]
        public List<ModifyOperateVulRequestVulInfo> VulInfo { get; set; }
        public class ModifyOperateVulRequestVulInfo : TeaModel {
            /// <summary>
            /// The ID of cloud desktop in which the vulnerability is detected.
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
