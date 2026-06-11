// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDocumentChunksRequest : TeaModel {
        /// <summary>
        /// <para>A filter pattern. The operation returns only the chunks whose titles contain this pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ChunkTitlePattern")]
        [Validation(Required=false)]
        public string ChunkTitlePattern { get; set; }

        /// <summary>
        /// <para>The name of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Omit this parameter to get the first page. If the response returns a <c>NextToken</c>, it indicates that more results are available. To get the next page, pass this <c>NextToken</c> value in the <c>NextToken</c> parameter of your next request. A null value for NextToken indicates that all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zCXSmY0CJbybp6FZV7vo0Wjw64X-*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>id</b> (default): The chunk ID.</para>
        /// </description></item>
        /// <item><description><para><b>hits</b>: The number of hits.</para>
        /// </description></item>
        /// <item><description><para><b>modifyTime</b>: The modification time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hits</para>
        /// </summary>
        [NameInMap("SortFieldName")]
        [Validation(Required=false)]
        public string SortFieldName { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ASC</b> (default): ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>DESC</b>: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
