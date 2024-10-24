// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortMaxConnsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of the details of the maximum number of connections that are established over a port of the instance.</para>
        /// </summary>
        [NameInMap("PortMaxConns")]
        [Validation(Required=false)]
        public List<DescribePortMaxConnsResponseBodyPortMaxConns> PortMaxConns { get; set; }
        public class DescribePortMaxConnsResponseBodyPortMaxConns : TeaModel {
            /// <summary>
            /// <para>The maximum number of connections per second (CPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.117</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08F79110-2AF5-4FA7-998E-7C5E75EACF9C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
