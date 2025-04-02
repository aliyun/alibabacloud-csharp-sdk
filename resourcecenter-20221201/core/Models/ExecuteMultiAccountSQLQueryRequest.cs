// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteMultiAccountSQLQueryRequest : TeaModel {
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
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search scope. The value of this parameter can be one of the following items:</para>
        /// <list type="bullet">
        /// <item><description>ID of a resource directory: Resources within the management account and all members of the resource directory are searched.</description></item>
        /// <item><description>ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched.</description></item>
        /// <item><description>ID of a folder: Resources within all members in the folder are searched.</description></item>
        /// <item><description>ID of a member: Resources within the member are searched.</description></item>
        /// <item><description>ID of a member/ID of a Resource group: Resources within the member in the resource group are searched.</description></item>
        /// </list>
        /// <para>For more information about how to obtain the ID of a resource directory, the Root folder, a folder, a member, or a resource group, see <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a>, <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a>, <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a>, <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>, or <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
