// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// The name of the job template.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The number of the page to return. The parameter value is a positive integer that is greater than or equal to 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The dimension by which applications are filtered. Valid values:
        /// 
        /// *   **appName**: Applications are filtered by job template name.
        /// *   **appIds**: Applications are filtered by job template ID.
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// Enter the name and ID of the job template.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The namespace ID.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// Specifies how applications are sorted. Valid values:
        /// 
        /// *   **running**: The applications are sorted based on the number of running instances.
        /// *   **instances**: The applications are sorted based on the number of destination instances.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid value: 0 to 200.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether to sort the field names that are passed by **OrderBy** in ascending order. Valid values:
        /// 
        /// *   **true**: in ascending order
        /// *   **false**: in descending order
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The tags that are displayed in a JSON string. Valid values:
        /// 
        /// *   **key**: the tag key
        /// *   **value**: the tag value
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Set the value to `job`.
        /// </summary>
        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}
