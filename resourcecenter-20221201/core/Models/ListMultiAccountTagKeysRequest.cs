// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountTagKeysRequest : TeaModel {
        /// <summary>
        /// <para>The matching mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Equals: equal match</description></item>
        /// <item><description>Prefix: match by prefix</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Equals</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>If the total number of entries returned for the current request exceeds the value of the <c>MaxResults</c> parameter, the entries are truncated. In this case, you can use the <c>token</c> to initiate another request and obtain the remaining entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search scope. The value of this parameter can be one of the following items:</para>
        /// <list type="bullet">
        /// <item><description>ID of a resource directory: Resources within the management account and all members of the resource directory are searched. You can call the <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a> operation to obtain the ID of the resource directory. The ID is indicated by the <c>ResourceDirectoryId</c> parameter in the response of the operation.</description></item>
        /// <item><description>ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched. You can call the <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a> operation to obtain the ID of the Root folder. The ID is indicated by the <c>RootFolderId</c> parameter in the response of the operation.</description></item>
        /// <item><description>ID of a folder: Resources within all members in the folder are searched. You can call the <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a> operation to obtain the ID of the folder. The ID is indicated by the <c>FolderId</c> parameter in the response of the operation.</description></item>
        /// <item><description>ID of a member: Resources within the member are searched. You can call the <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a> operation to obtain the ID of the member. The ID is indicated by the <c>AccountId</c> parameter in the response of the operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_key</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

    }

}
