// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSignatureLibVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <para>The information about the versions.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public List<DescribeSignatureLibVersionResponseBodyVersion> Version { get; set; }
        public class DescribeSignatureLibVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ips</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>Basic Rules and Virtual Patching</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>intelligence</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>Threat Intelligence</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ips</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number.</para>
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
