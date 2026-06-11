// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>The document property filter. The following properties are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>fileExt</c>: The document extension.</para>
        /// </description></item>
        /// <item><description><para><c>state</c>: The document status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fileExt&quot;:&quot;pdf&quot;,&quot;state&quot;:0}</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

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
        /// <para>The maximum number of documents to return per page.</para>
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
        /// <para>The document name filter. Returns only documents whose names contain this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NamePattern")]
        [Validation(Required=false)]
        public string NamePattern { get; set; }

        /// <summary>
        /// <para>The pagination token to retrieve the next page of results. Omit this parameter to retrieve the first page. A <c>NextToken</c> value in the response indicates that more results are available. To fetch the next page, pass this value in a subsequent request. A <c>null</c> value indicates that all results have been retrieved.</para>
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
        /// <item><description><para><c>id</c> (default): The document ID.</para>
        /// </description></item>
        /// <item><description><para><c>hits</c>: The number of hits.</para>
        /// </description></item>
        /// <item><description><para><c>modifyTime</c>: The modification time.</para>
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
        /// <item><description><para><b>ASC</b> (default): Sorts in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>DESC</b>: Sorts in descending order.</para>
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
