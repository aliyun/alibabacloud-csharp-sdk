// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreatePatchBaselineResponseBody : TeaModel {
        /// <summary>
        /// The details of the patch baseline.
        /// </summary>
        [NameInMap("PatchBaseline")]
        [Validation(Required=false)]
        public CreatePatchBaselineResponseBodyPatchBaseline PatchBaseline { get; set; }
        public class CreatePatchBaselineResponseBodyPatchBaseline : TeaModel {
            /// <summary>
            /// The rules of scanning and installing patches for the specified operating system.
            /// </summary>
            [NameInMap("ApprovalRules")]
            [Validation(Required=false)]
            public string ApprovalRules { get; set; }

            [NameInMap("ApprovedPatches")]
            [Validation(Required=false)]
            public List<string> ApprovedPatches { get; set; }

            [NameInMap("ApprovedPatchesEnableNonSecurity")]
            [Validation(Required=false)]
            public bool? ApprovedPatchesEnableNonSecurity { get; set; }

            /// <summary>
            /// The creator of the patch baseline.
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// The time when the patch baseline was created.
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// The description of the patch baseline.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the patch baseline.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the patch baseline.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the operating system.
            /// </summary>
            [NameInMap("OperationSystem")]
            [Validation(Required=false)]
            public string OperationSystem { get; set; }

            [NameInMap("RejectedPatches")]
            [Validation(Required=false)]
            public List<string> RejectedPatches { get; set; }

            [NameInMap("RejectedPatchesAction")]
            [Validation(Required=false)]
            public string RejectedPatchesAction { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The share type of the patch baseline.
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("Sources")]
            [Validation(Required=false)]
            public List<string> Sources { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreatePatchBaselineResponseBodyPatchBaselineTags> Tags { get; set; }
            public class CreatePatchBaselineResponseBodyPatchBaselineTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The Alibaba Cloud account that last modified the information about the patch baseline.
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// The time when the information about the patch baseline was last modified.
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
