// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class ListYikeAssetFoldersResponseBody : TeaModel {
        [NameInMap("FolderList")]
        [Validation(Required=false)]
        public List<ListYikeAssetFoldersResponseBodyFolderList> FolderList { get; set; }
        public class ListYikeAssetFoldersResponseBodyFolderList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("ProductionId")]
            [Validation(Required=false)]
            public string ProductionId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
