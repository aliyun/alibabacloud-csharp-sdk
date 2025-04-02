// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetSymbolicFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>Args</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetSymbolicFilesResponseBodyModel Model { get; set; }
        public class GetSymbolicFilesResponseBodyModel : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetSymbolicFilesResponseBodyModelItems> Items { get; set; }
            public class GetSymbolicFilesResponseBodyModelItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e8a1a2b9ab653780b34383a942ac91b2</para>
                /// </summary>
                [NameInMap("BuildId")]
                [Validation(Required=false)]
                public string BuildId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXPORT_SUCCESS</para>
                /// </summary>
                [NameInMap("ExportStatus")]
                [Validation(Required=false)]
                public string ExportStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>app_so.zip</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24781204@android/1743506690915-app_so.zip</para>
                /// </summary>
                [NameInMap("FilePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>APP_SO</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1655962713000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>392522</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>uuid</para>
                /// 
                /// <b>Example:</b>
                /// <para>9634758587856312DEV</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public int? Pages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3AD0FE4-36EF-1641-90B1-77618166F2ff</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
