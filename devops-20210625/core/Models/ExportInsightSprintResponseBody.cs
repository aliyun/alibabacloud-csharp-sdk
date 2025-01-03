// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExportInsightSprintResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExportInsightSprintResponseBodyResult> Result { get; set; }
        public class ExportInsightSprintResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1711936113000</para>
            /// </summary>
            [NameInMap("actualEnd")]
            [Validation(Required=false)]
            public long? ActualEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1711936113000</para>
            /// </summary>
            [NameInMap("actualStart")]
            [Validation(Required=false)]
            public long? ActualStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1710989643000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1711728000000</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1711936113000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1711936113000</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18471761</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e4895cadc86632f34dfaa7xxxx</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public string IsDeleted { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>61db9af2148974246bexxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>385e7e5a4be6791f0a5185xxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>projex</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60.0</para>
            /// </summary>
            [NameInMap("workTimeCapacity")]
            [Validation(Required=false)]
            public double? WorkTimeCapacity { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
