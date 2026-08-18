// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The connection bandwidth of the endpoint. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The endpoint connection status. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disconnected</para>
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T19:11:12Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The cross-region bandwidth value of the endpoint. This parameter is applicable only when the endpoint and the endpoint service are in different regions. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CrossRegionBandwidth")]
        [Validation(Required=false)]
        public int? CrossRegionBandwidth { get; set; }

        /// <summary>
        /// <para>The business status of the endpoint. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("EndpointBusinessStatus")]
        [Validation(Required=false)]
        public string EndpointBusinessStatus { get; set; }

        /// <summary>
        /// <para>The description of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Endpoint.</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The endpoint domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****.epsrv-hp3xdsq46ael67lo****.cn-huhehaote.privatelink.aliyuncs.com</para>
        /// </summary>
        [NameInMap("EndpointDomain")]
        [Validation(Required=false)]
        public string EndpointDomain { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The endpoint status. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint service that is associated with the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint service that is associated with the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3xdsq46ael67lo****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The VPC to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp356stwkxg3fn2xe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to support zone affinity for the endpoint domain name when connecting to the service. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
