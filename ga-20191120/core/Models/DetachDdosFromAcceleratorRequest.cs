// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DetachDdosFromAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>A list of Anti-DDoS Pro or Anti-DDoS Premium instances that are associated with the Global Accelerator instance.</para>
        /// </summary>
        [NameInMap("DdosConfigList")]
        [Validation(Required=false)]
        public List<DetachDdosFromAcceleratorRequestDdosConfigList> DdosConfigList { get; set; }
        public class DetachDdosFromAcceleratorRequestDdosConfigList : TeaModel {
            /// <summary>
            /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance that is associated with the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosDip-cn-pj64b8cz101</para>
            /// </summary>
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            /// <summary>
            /// <para>The region where the Anti-DDoS Pro or Anti-DDoS Premium instance is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("DdosRegionId")]
            [Validation(Required=false)]
            public string DdosRegionId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the system returns an HTTP 2xx status code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, an HTTP 2xx status code is returned and the instance is detached.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
