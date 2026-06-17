// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSignatureLibVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C50C2A9-4BBB-5504-8ADA-C41A79B8C946</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The version information.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public List<DescribeSignatureLibVersionResponseBodyVersion> Version { get; set; }
        public class DescribeSignatureLibVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The type of the signature library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ips</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the signature library was updated. This value is a Unix timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741067915</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number of the signature library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPS-2307-02</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
