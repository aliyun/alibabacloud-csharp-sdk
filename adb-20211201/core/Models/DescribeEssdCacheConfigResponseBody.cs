// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeEssdCacheConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEssdCacheConfigResponseBodyData Data { get; set; }
        public class DescribeEssdCacheConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the disk cache feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableEssdCache")]
            [Validation(Required=false)]
            public bool? EnableEssdCache { get; set; }

            /// <summary>
            /// <para>The disk cache size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("EssdCacheSize")]
            [Validation(Required=false)]
            public int? EssdCacheSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7EDB8E4-9769-4233-88C7-DCA4C9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
