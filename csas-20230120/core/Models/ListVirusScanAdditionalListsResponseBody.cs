// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanAdditionalListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The blacklists and whitelists grouped by matching dimension. If a matching dimension contains no list entries, that dimension does not appear in the list.</para>
        /// </summary>
        [NameInMap("AdditionalLists")]
        [Validation(Required=false)]
        public List<ListVirusScanAdditionalListsResponseBodyAdditionalLists> AdditionalLists { get; set; }
        public class ListVirusScanAdditionalListsResponseBodyAdditionalLists : TeaModel {
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
            /// <para>The lists grouped by list type under this matching dimension.</para>
            /// </summary>
            [NameInMap("Lists")]
            [Validation(Required=false)]
            public List<ListVirusScanAdditionalListsResponseBodyAdditionalListsLists> Lists { get; set; }
            public class ListVirusScanAdditionalListsResponseBodyAdditionalListsLists : TeaModel {
                /// <summary>
                /// <para>The list of entries.</para>
                /// </summary>
                [NameInMap("ListDetail")]
                [Validation(Required=false)]
                public List<ListVirusScanAdditionalListsResponseBodyAdditionalListsListsListDetail> ListDetail { get; set; }
                public class ListVirusScanAdditionalListsResponseBodyAdditionalListsListsListDetail : TeaModel {
                    /// <summary>
                    /// <para>The creation time of the list entry, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-08-21 10:24:31</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The content of the list entry. The meaning is determined by the AdditionalType to which it belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.tmp</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    /// <summary>
                    /// <para>The list entry ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>additional-list-4d7b1e9a6c38****</para>
                    /// </summary>
                    [NameInMap("ListId")]
                    [Validation(Required=false)]
                    public string ListId { get; set; }

                }

                /// <summary>
                /// <para>The list type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Blacklist</b>: Blacklist. Files that match are directly identified as virus files.</description></item>
                /// <item><description><b>Whitelist</b>: Whitelist. Files that match are excluded from virus detection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Whitelist</para>
                /// </summary>
                [NameInMap("ListType")]
                [Validation(Required=false)]
                public string ListType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
