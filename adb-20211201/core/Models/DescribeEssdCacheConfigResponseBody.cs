// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeEssdCacheConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEssdCacheConfigResponseBodyData Data { get; set; }
        public class DescribeEssdCacheConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableEssdCache")]
            [Validation(Required=false)]
            public bool? EnableEssdCache { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("EssdCacheSize")]
            [Validation(Required=false)]
            public int? EssdCacheSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C7EDB8E4-9769-4233-88C7-DCA4C9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
