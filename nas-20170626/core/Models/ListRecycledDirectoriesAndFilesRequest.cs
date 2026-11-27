// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycledDirectoriesAndFilesRequest : TeaModel {
        /// <summary>
        /// <para>The FileId of the directory to be queried.</para>
        /// <para>This field is the NFS inode number. When the recycle bin is empty, you can set FileId to 2 (the inode of the root directory) to directly call this operation to verify the accessibility of the operation or query the content of the recycle bin in the root directory. You can call the <a href="https://help.aliyun.com/document_detail/2412173.html">ListRecentlyRecycledDirectories</a> operation to query other valid FileIds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04***08</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of files or directories to return per query.</para>
        /// <para>Valid values: 10 to 1000.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. You do not need to specify this parameter for the first query.</para>
        /// <para>If the query does not return all files and directories, a non-empty NextToken is returned.
        /// You can use the returned NextToken to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1256****25</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
