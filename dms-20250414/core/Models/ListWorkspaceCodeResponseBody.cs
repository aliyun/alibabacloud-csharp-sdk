// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListWorkspaceCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned in the response.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkspaceCodeResponseBodyData Data { get; set; }
        public class ListWorkspaceCodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of objects representing the files and directories.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListWorkspaceCodeResponseBodyDataList> List { get; set; }
            public class ListWorkspaceCodeResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the object is a directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// <para>The modification time of the file.</para>
                /// <para>The time is in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
                /// <para>This parameter is returned only for files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T10:11:12Z</para>
                /// </summary>
                [NameInMap("Mtime")]
                [Validation(Required=false)]
                public string Mtime { get; set; }

                /// <summary>
                /// <para>The name of the file or directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The file size in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The target of the symlink.</para>
                /// 
                /// <b>Example:</b>
                /// <para>../abc.py</para>
                /// </summary>
                [NameInMap("Symlink")]
                [Validation(Required=false)]
                public string Symlink { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This record is being collected, please wait for a moment.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
