// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreatePatchBaselineShrinkRequest : TeaModel {
        /// <summary>
        /// The rules of scanning and installing patches for the specified operating system.
        /// </summary>
        [NameInMap("ApprovalRules")]
        [Validation(Required=false)]
        public string ApprovalRules { get; set; }

        [NameInMap("ApprovedPatches")]
        [Validation(Required=false)]
        public string ApprovedPatchesShrink { get; set; }

        [NameInMap("ApprovedPatchesEnableNonSecurity")]
        [Validation(Required=false)]
        public bool? ApprovedPatchesEnableNonSecurity { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the patch baseline.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the patch baseline.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the operating system. Valid values:
        /// 
        /// *   Windows
        /// *   Ubuntu
        /// *   CentOS
        /// *   Debian
        /// *   AliyunLinux
        /// *   RedhatEnterpriseLinux
        /// *   Anolis
        /// *   AlmaLinux
        /// </summary>
        [NameInMap("OperationSystem")]
        [Validation(Required=false)]
        public string OperationSystem { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create a patch baseline.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RejectedPatches")]
        [Validation(Required=false)]
        public string RejectedPatchesShrink { get; set; }

        [NameInMap("RejectedPatchesAction")]
        [Validation(Required=false)]
        public string RejectedPatchesAction { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
