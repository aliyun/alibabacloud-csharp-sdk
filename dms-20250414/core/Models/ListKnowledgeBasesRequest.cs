// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListKnowledgeBasesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the knowledge bases, specified as a JSON string. The only supported key is <c>state</c>. Valid values are <c>0</c> and <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;state&quot;:1}</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Use this parameter with the <c>NextToken</c> parameter to implement pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A keyword to search for in the names of knowledge bases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("NamePattern")]
        [Validation(Required=false)]
        public string NamePattern { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Omit this parameter for the first request.</para>
        /// </description></item>
        /// <item><description><para>If the previous response returned a <b>NextToken</b> value, use it to retrieve the next page of results.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><c>id</c>: Sorts by knowledge base ID. This is the default.</para>
        /// </description></item>
        /// <item><description><para><c>name</c>: Sorts by knowledge base name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SortFieldName")]
        [Validation(Required=false)]
        public string SortFieldName { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ASC</b>: Ascending order. This is the default.</para>
        /// </description></item>
        /// <item><description><para><b>DESC</b>: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The tag of the knowledge base. In DataAgent, this is the space ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dq7qod8hxtt1***</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
