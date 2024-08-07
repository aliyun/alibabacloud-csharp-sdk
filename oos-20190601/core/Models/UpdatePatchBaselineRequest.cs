// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdatePatchBaselineRequest : TeaModel {
        /// <summary>
        /// The rules of scanning and installing patches for the specified operating system.
        /// </summary>
        [NameInMap("ApprovalRules")]
        [Validation(Required=false)]
        public string ApprovalRules { get; set; }

        /// <summary>
        /// The approved patches.
        /// </summary>
        [NameInMap("ApprovedPatches")]
        [Validation(Required=false)]
        public List<string> ApprovedPatches { get; set; }

        /// <summary>
        /// Indicates whether the approved patch involves updates other than security-related updates.
        /// </summary>
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The rejected patches.
        /// </summary>
        [NameInMap("RejectedPatches")]
        [Validation(Required=false)]
        public List<string> RejectedPatches { get; set; }

        /// <summary>
        /// The action of the rejected patch.
        /// </summary>
        [NameInMap("RejectedPatchesAction")]
        [Validation(Required=false)]
        public string RejectedPatchesAction { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The patch source configurations.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdatePatchBaselineRequestTags> Tags { get; set; }
        public class UpdatePatchBaselineRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
