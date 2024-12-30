// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDeltaResponseBody : TeaModel {
        /// <summary>
        /// <para>The cursor of the incremental information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1WQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>Indicates whether more information is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("has_more")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The incremental information returned.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListDeltaResponseBodyItems> Items { get; set; }
        public class ListDeltaResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The information about the file.</para>
            /// </summary>
            [NameInMap("file")]
            [Validation(Required=false)]
            public File File { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122fb09598ae66777c7040109a16f49381f6abe2</para>
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The operation that is performed. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description>create</description></item>
            /// <item><description>overwrite</description></item>
            /// <item><description>delete</description></item>
            /// <item><description>update</description></item>
            /// <item><description>move</description></item>
            /// <item><description>trash</description></item>
            /// <item><description>restore</description></item>
            /// <item><description>rename</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>create</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

    }

}
