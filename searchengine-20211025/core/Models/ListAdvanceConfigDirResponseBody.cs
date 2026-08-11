// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigDirResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAdvanceConfigDirResponseBodyResult> Result { get; set; }
        public class ListAdvanceConfigDirResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The full path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/path/wpd/nae</para>
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// <para>Indicates whether the entry is a directory. Valid values: - true: The entry is a directory. - false: The entry is not a directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// <para>Indicates whether the entry is a template. Valid values: - <b>true</b>: The entry is a template. - <b>false</b>: The entry is not a template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz_pre_vpc_domain_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
