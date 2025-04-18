// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTasksRequest : TeaModel {
        [NameInMap("InspectionName")]
        [Validation(Required=false)]
        public string InspectionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InspectionProject")]
        [Validation(Required=false)]
        public string InspectionProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ni-8svm******hzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml1/R9jhHkiH8eW3CfaOYU0CEL7yiT0zae6J8v1zYNg+d1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
