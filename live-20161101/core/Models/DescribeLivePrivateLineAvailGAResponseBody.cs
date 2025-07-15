// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePrivateLineAvailGAResponseBody : TeaModel {
        /// <summary>
        /// <para>The GA instance configuration details.</para>
        /// </summary>
        [NameInMap("LivePrivateLineAvailGAs")]
        [Validation(Required=false)]
        public DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAs LivePrivateLineAvailGAs { get; set; }
        public class DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAs : TeaModel {
            [NameInMap("LivePrivateLineAvailGA")]
            [Validation(Required=false)]
            public List<DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAsLivePrivateLineAvailGA> LivePrivateLineAvailGA { get; set; }
            public class DescribeLivePrivateLineAvailGAResponseBodyLivePrivateLineAvailGAsLivePrivateLineAvailGA : TeaModel {
                /// <summary>
                /// <para>The acceleration channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("AccelerationArea")]
                [Validation(Required=false)]
                public string AccelerationArea { get; set; }

                /// <summary>
                /// <para>The acceleration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>play: streaming acceleration</description></item>
                /// <item><description>publish: stream ingest acceleration</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>play</para>
                /// </summary>
                [NameInMap("AccelerationType")]
                [Validation(Required=false)]
                public string AccelerationType { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>Indicates whether the GA instance is bound to an acceleration circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>yes</description></item>
                /// <item><description>no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>yes</para>
                /// </summary>
                [NameInMap("BindingStatus")]
                [Validation(Required=false)]
                public string BindingStatus { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The accelerated IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                /// <summary>
                /// <para>The ID of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ga-bp1iovsdpf01ym9su****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The status of the GA instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>active: The GA instance is available.</description></item>
                /// <item><description>inactive: The GA instance is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testStream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The user ID (UID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1833220971116****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <para>The live center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("VideoCenter")]
                [Validation(Required=false)]
                public string VideoCenter { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4865B85-664B-19D3-BB16-C62FB83C8226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
