// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of details of the IP address in the whitelist of the instance.</para>
        /// </summary>
        [NameInMap("AutoCcWhitelist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist> AutoCcWhitelist { get; set; }
        public class DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist : TeaModel {
            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.117</para>
            /// </summary>
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            /// <summary>
            /// <para>The validity period of the IP address in the whitelist. Unit: seconds. <b>0</b> indicates that the IP address in the whitelist never expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The IP addresses that is contained in the IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.2.2</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The mode of how an IP address is added to the whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>manual</b>: manually added</description></item>
            /// <item><description><b>auto</b>: automatically added</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F09D085E-5E0F-4FF2-B32E-F4A644049162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned IP addresses in the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
