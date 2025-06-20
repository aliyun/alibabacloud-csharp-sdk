// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteSQLQueryRequest : TeaModel {
        /// <summary>
        /// <para>The SQL statement to be executed.</para>
        /// <para>The number of characters in the SQL statement must be less than 2,000.</para>
        /// <para>For more information about the SQL syntax, see <a href="https://help.aliyun.com/document_detail/2539395.html">Basic SQL syntax</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM resources LIMIT 100;</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 1000.</description></item>
        /// <item><description>Default value: 1000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search scope.</para>
        /// <para>Set this parameter to the ID of a resource group.</para>
        /// <para>For information about how to obtain the ID of a resource group, see <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
