// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddVirusScanAdditionalListsRequest : TeaModel {
        /// <summary>
        /// <para>The list of entries to append. At least one entry is required.</para>
        /// </summary>
        [NameInMap("AdditionalLists")]
        [Validation(Required=false)]
        public List<AddVirusScanAdditionalListsRequestAdditionalLists> AdditionalLists { get; set; }
        public class AddVirusScanAdditionalListsRequestAdditionalLists : TeaModel {
            /// <summary>
            /// <para>The matching dimension of the list entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FileSuffix</b>: matches by file name extension.</description></item>
            /// <item><description><b>FileName</b>: matches by file name.</description></item>
            /// <item><description><b>FolderName</b>: matches by folder name.</description></item>
            /// <item><description><b>FilePath</b>: matches by file path.</description></item>
            /// <item><description><b>FileMd5</b>: matches by file MD5 value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FileSuffix</para>
            /// </summary>
            [NameInMap("AdditionalType")]
            [Validation(Required=false)]
            public string AdditionalType { get; set; }

            /// <summary>
            /// <para>The content of the list entry. The value cannot exceed 255 characters. The meaning is determined by AdditionalType: when AdditionalType is set to FileSuffix, specify a file name extension. When set to FileName, specify a file name. When set to FolderName, specify a folder name. When set to FilePath, specify a file path. When set to FileMd5, specify the MD5 value of a file.</para>
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
            /// <item><description><b>Blacklist</b>: blacklist. Files that match are directly identified as virus files.</description></item>
            /// <item><description><b>Whitelist</b>: whitelist. Files that match are excluded from virus detection.</description></item>
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
        /// <para>The operating system type for which the list takes effect. Valid values:</para>
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
