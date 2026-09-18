// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGroupDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query root itself and all its descendant directories, including visible referenced directories in the space. The results are not paginated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("directories")]
        [Validation(Required=false)]
        public List<ListGroupDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class ListGroupDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// <para>The directory description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Project description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory ID, including the query root itself and its descendants.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dir_example</para>
            /// </summary>
            [NameInMap("directoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The original directory type. The value is GROUP for physical directories in the space. Referenced directories retain their original type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GROUP</para>
            /// </summary>
            [NameInMap("directoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Project resources</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parent directory ID. This value is empty for the internal root of the space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dir_parent</para>
            /// </summary>
            [NameInMap("parentDirectoryId")]
            [Validation(Required=false)]
            public string ParentDirectoryId { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory is a read-only referenced directory. A value of false still requires creator or administrator permissions to modify the directory. The internal root is always unmodifiable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("readOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

        }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned directories, which equals the length of the directories array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
