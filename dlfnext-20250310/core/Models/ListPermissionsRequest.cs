// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database_name</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>function_name</para>
        /// </summary>
        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of data. If the response does not include this token, pass an empty string (&quot;&quot;) or an empty character (\&quot;\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <para>The user resource descriptor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:user/user_name</para>
        /// </summary>
        [NameInMap("principal")]
        [Validation(Required=false)]
        public string Principal { get; set; }

        /// <summary>
        /// <para>The permission resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALOG</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The data table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>The view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view_name</para>
        /// </summary>
        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}
