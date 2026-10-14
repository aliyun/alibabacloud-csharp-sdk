// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlackholeStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The blackhole filtering status information of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// </summary>
        [NameInMap("BlackholeStatus")]
        [Validation(Required=false)]
        public List<DescribeBlackholeStatusResponseBodyBlackholeStatus> BlackholeStatus { get; set; }
        public class DescribeBlackholeStatusResponseBodyBlackholeStatus : TeaModel {
            /// <summary>
            /// <para>The blackhole filtering status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>blackhole</b>: Black Hole Activated</para>
            /// </description></item>
            /// <item><description><para><b>normal</b>: Normal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blackhole</para>
            /// </summary>
            [NameInMap("BlackStatus")]
            [Validation(Required=false)]
            public string BlackStatus { get; set; }

            /// <summary>
            /// <para>The end time of blackhole filtering. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1540196323</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The IP address of the Anti-DDoS Proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.132</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The start time of blackhole filtering. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1540195323</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
