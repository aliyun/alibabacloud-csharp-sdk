// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListTableDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to retrieve in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of data. If the response does not provide this value, pass an empty string (&quot;&quot;) or an empty character (\&quot;\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <para>The deletion status of the table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>retained: The table is deleted and temporarily stored in the recycle bin.</description></item>
        /// <item><description>active: The table is in a normal state. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The fuzzy match pattern for the table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table%</para>
        /// </summary>
        [NameInMap("tableNamePattern")]
        [Validation(Required=false)]
        public string TableNamePattern { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
