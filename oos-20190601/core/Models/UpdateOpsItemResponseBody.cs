// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateOpsItemResponseBody : TeaModel {
        /// <summary>
        /// The information about the O\&M item.
        /// </summary>
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public UpdateOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class UpdateOpsItemResponseBodyOpsItem : TeaModel {
            /// <summary>
            /// The attributes of the O\&M item.
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// The category.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The time when the O\&M item was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The user who created the patch baseline.
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The user who modified the O\&M item.
            /// </summary>
            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// The ID of the O\&M item.
            /// </summary>
            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            /// <summary>
            /// The priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ARNs of the associated resources.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

            /// <summary>
            /// The severity level.
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The solutions.
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<string> Solutions { get; set; }

            /// <summary>
            /// The source business.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// The title of the O\&M item.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The time when the O\&M item was updated.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
