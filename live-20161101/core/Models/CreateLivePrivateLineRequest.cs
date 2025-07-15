// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLivePrivateLineRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration channel.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>play</para>
        /// </summary>
        [NameInMap("AccelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The acceleration channel that you want to reuse. This parameter is required if Reuse is set to yes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1iovsdpf01ym9su****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The accelerated bandwidth. Unit: Mbit/s. This parameter is required if Reuse is set to no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public string MaxBandwidth { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse an existing acceleration channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>yes: reuses an existing acceleration channel.</description></item>
        /// <item><description>no: creates a new acceleration channel.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("Reuse")]
        [Validation(Required=false)]
        public string Reuse { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testStream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The live center. Valid values: cn-beijing, cn-shanghai, cn-shenzhen, cn-qingdao, ap-northeast-1, ap-southeast-5, eu-central-1, and ap-southeast-1, which indicate China (Beijing), China (Shanghai), China (Shenzhen), China (Qingdao), Japan (Tokyo), Indonesia (Jakarta), Germany (Frankfurt), and Singapore, respectively.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("VideoCenter")]
        [Validation(Required=false)]
        public string VideoCenter { get; set; }

    }

}
