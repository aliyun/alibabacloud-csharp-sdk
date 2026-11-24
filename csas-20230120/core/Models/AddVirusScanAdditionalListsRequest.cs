// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddVirusScanAdditionalListsRequest : TeaModel {
        /// <summary>
        /// <para>The list of entries to add. The list must contain at least one entry.</para>
        /// </summary>
        [NameInMap("AdditionalLists")]
        [Validation(Required=false)]
        public List<AddVirusScanAdditionalListsRequestAdditionalLists> AdditionalLists { get; set; }
        public class AddVirusScanAdditionalListsRequestAdditionalLists : TeaModel {
            /// <summary>
            /// <para>The matching dimension of the list entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FileSuffix</b>: Matches by file name extension.</description></item>
            /// <item><description><b>FileName</b>: Matches by file name.</description></item>
            /// <item><description><b>FolderName</b>: Matches by folder name.</description></item>
            /// <item><description><b>FilePath</b>: Matches by file path.</description></item>
            /// <item><description><b>FileMd5</b>: Matches by file MD5 hash.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FileSuffix</para>
            /// </summary>
            [NameInMap("AdditionalType")]
            [Validation(Required=false)]
            public string AdditionalType { get; set; }

            /// <summary>
            /// <para>The content of the list entry. The value can be up to 255 characters in length. The meaning of this parameter is determined by the AdditionalType parameter. If AdditionalType is set to FileSuffix, specify the file name extension. If AdditionalType is set to FileName, specify the file name. If AdditionalType is set to FolderName, specify the folder name. If AdditionalType is set to FilePath, specify the file path. If AdditionalType is set to FileMd5, specify the MD5 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.tmp</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The list type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Blacklist</b>: Blacklist. Matched files are directly identified as virus files.</description></item>
            /// <item><description><b>Whitelist</b>: Whitelist. Matched files are excluded from virus detection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Whitelist</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public string ListType { get; set; }

        }

        /// <summary>
        /// <para>The operating system type to which the list applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows.</description></item>
        /// <item><description><b>macOS</b>: macOS.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

    }

}
