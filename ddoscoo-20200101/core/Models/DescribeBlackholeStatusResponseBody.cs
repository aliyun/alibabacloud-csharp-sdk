// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlackholeStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the blackhole filtering status of the instance.</para>
        /// </summary>
        [NameInMap("BlackholeStatus")]
        [Validation(Required=false)]
        public List<DescribeBlackholeStatusResponseBodyBlackholeStatus> BlackholeStatus { get; set; }
        public class DescribeBlackholeStatusResponseBodyBlackholeStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether blackhole filtering is triggered for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>blackhole</b>: yes</description></item>
            /// <item><description><b>normal</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blackhole</para>
            /// </summary>
            [NameInMap("BlackStatus")]
            [Validation(Required=false)]
            public string BlackStatus { get; set; }

            /// <summary>
            /// <para>The end time of blackhole filtering. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1540196323</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.132</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The start time of blackhole filtering. The value is a UNIX timestamp. Unit: seconds.</para>
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
