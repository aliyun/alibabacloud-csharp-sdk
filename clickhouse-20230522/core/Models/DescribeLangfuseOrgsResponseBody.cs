// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeLangfuseOrgsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLangfuseOrgsResponseBodyData Data { get; set; }
        public class DescribeLangfuseOrgsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Langfuse organization information.</para>
            /// </summary>
            [NameInMap("Organizations")]
            [Validation(Required=false)]
            public List<DescribeLangfuseOrgsResponseBodyDataOrganizations> Organizations { get; set; }
            public class DescribeLangfuseOrgsResponseBodyDataOrganizations : TeaModel {
                /// <summary>
                /// <para>The time when the Langfuse organization was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-11T10:27:23Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The Langfuse organization name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Langfuse organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmrbhzx930005jw2q****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>The time when the Langfuse organization was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-09T10:27:55</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
