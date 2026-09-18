// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for the current cursor-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty string is returned if there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number for compatible page-number-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for compatible page-number-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of Skill summaries. The current public contract does not define a fixed structure for list items. For common fields, see &quot;Supplementary description of response elements&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;skillId&quot;:&quot;skill_example123&quot;,&quot;name&quot;:&quot;code-review&quot;,&quot;official&quot;:false,&quot;description&quot;:&quot;A Skill for performing code reviews&quot;,&quot;iconUrl&quot;:&quot;<a href="https://example.com/icons/code-review.png%22,%22visibility%22:%22user%22,%22status%22:%22PUBLISHED%22,%22publishedVersion%22:2,%22creatorId%22:%22example-user%22,%22createdAt%22:1760000000000,%22canModify%22:true,%22canDelete%22:true%7D%5D">https://example.com/icons/code-review.png&quot;,&quot;visibility&quot;:&quot;user&quot;,&quot;status&quot;:&quot;PUBLISHED&quot;,&quot;publishedVersion&quot;:2,&quot;creatorId&quot;:&quot;example-user&quot;,&quot;createdAt&quot;:1760000000000,&quot;canModify&quot;:true,&quot;canDelete&quot;:true}]</a></para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<object> Skills { get; set; }

        /// <summary>
        /// <para>The total number of Skills that match the current visibility and filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
