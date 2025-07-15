// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePrivateLineAvailGARequest : TeaModel {
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
        /// <para>The name of the application.</para>
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
        /// <para>Specifies whether to query Global Accelerator (GA) instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>yes: queries the status of GA instances.</description></item>
        /// <item><description>no: queries the binding information between GA instances and acceleration circuits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("IsGaInstance")]
        [Validation(Required=false)]
        public string IsGaInstance { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The live center. Valid values: cn-beijing, cn-shanghai, cn-shenzhen, cn-qingdao, ap-northeast-1, ap-southeast-5, eu-central-1, ap-southeast-1, and ap-south-1. cn-beijing indicates China (Beijing). cn-shanghai indicates China (Shanghai). cn-shenzhen indicates China (Shenzhen). cn-qingdao indicates China (Qingdao). ap-northeast-1 indicates Japan (Tokyo). ap-southeast-5 indicates Indonesia (Jakarta). eu-central-1 indicates Germany (Frankfurt). ap-southeast-1 indicates Singapore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("VideoCenter")]
        [Validation(Required=false)]
        public string VideoCenter { get; set; }

    }

}
