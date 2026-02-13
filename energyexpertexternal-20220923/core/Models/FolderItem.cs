// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class FolderItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentLevel")]
        [Validation(Required=false)]
        public int? CurrentLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("docCount")]
        [Validation(Required=false)]
        public int? DocCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("folderDefault")]
        [Validation(Required=false)]
        public int? FolderDefault { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4b648f6d11344f258df876cbdc24dc1f</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“abc” “1234”</para>
        /// </summary>
        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("folderNum")]
        [Validation(Required=false)]
        public int? FolderNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aidoc-energy-api-example.oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ossDomain")]
        [Validation(Required=false)]
        public string OssDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test/</para>
        /// </summary>
        [NameInMap("ossPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1696462764375572</para>
        /// </summary>
        [NameInMap("ossUpdateBy")]
        [Validation(Required=false)]
        public string OssUpdateBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;0&quot; ：parent folder is root
        /// &quot;4b648f6d11344f258df876cbdc24dc1f&quot; ： folderId</para>
        /// </summary>
        [NameInMap("parentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>folder/manual/</para>
        /// </summary>
        [NameInMap("resourcePath")]
        [Validation(Required=false)]
        public string ResourcePath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("storageType")]
        [Validation(Required=false)]
        public int? StorageType { get; set; }

        [NameInMap("subFolderList")]
        [Validation(Required=false)]
        public List<FolderItem> SubFolderList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("syncParsingStatus")]
        [Validation(Required=false)]
        public int? SyncParsingStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("syncStatus")]
        [Validation(Required=false)]
        public int? SyncStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
