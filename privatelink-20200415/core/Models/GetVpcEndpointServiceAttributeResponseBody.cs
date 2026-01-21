// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointServiceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>DualStack</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether endpoint connection requests are automatically accepted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        /// <summary>
        /// <para>The default maximum bandwidth of the endpoint connection. Unit: Mbit/s. Valid values: <b>100</b> to 10240.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        /// <summary>
        /// <para>The time when the endpoint service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-02T19:11:12Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the endpoint connection. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth of the endpoint connection. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MinBandwidth")]
        [Validation(Required=false)]
        public int? MinBandwidth { get; set; }

        /// <summary>
        /// <para>The payer of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Endpoint</b>: the service consumer.</description></item>
        /// <item><description><b>EndpointService</b>: the service provider.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8992C1-6712-423C-BAC5-E5E817484C6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The service status of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The endpoint service runs as expected.</description></item>
        /// <item><description><b>FinancialLocked</b>: The endpoint service is locked due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("ServiceBusinessStatus")]
        [Validation(Required=false)]
        public string ServiceBusinessStatus { get; set; }

        /// <summary>
        /// <para>The description of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my EndpointService.</para>
        /// </summary>
        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// <para>The domain name of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****.cn-huhehaote.privatelink.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceDomain")]
        [Validation(Required=false)]
        public string ServiceDomain { get; set; }

        /// <summary>
        /// <para>The endpoint service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The type of the service resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slb</b>: a CLB instance.</description></item>
        /// <item><description><b>alb</b>: an ALB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        /// <summary>
        /// <para>The state of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The endpoint service is being created.</description></item>
        /// <item><description><b>Pending</b>: The endpoint service is being modified.</description></item>
        /// <item><description><b>Active</b>: The endpoint service is available.</description></item>
        /// <item><description><b>Deleting</b>: The endpoint service is being deleted.</description></item>
        /// <item><description><b>Inactive</b>: The endpoint service is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether the endpoint service supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceSupportIPv6")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ServiceSupportIPv6 { get; set; }

        /// <summary>
        /// <para>The type of the endpoint.</para>
        /// <para>Only <b>Interface</b> is returned. The value indicates the interface endpoint. Then, you can specify ALB and CLB instances as service resources for the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("SupportedRegionSet")]
        [Validation(Required=false)]
        public List<GetVpcEndpointServiceAttributeResponseBodySupportedRegionSet> SupportedRegionSet { get; set; }
        public class GetVpcEndpointServiceAttributeResponseBodySupportedRegionSet : TeaModel {
            [NameInMap("RegionBusinessStatus")]
            [Validation(Required=false)]
            public string RegionBusinessStatus { get; set; }

            [NameInMap("RegionServiceStatus")]
            [Validation(Required=false)]
            public string RegionServiceStatus { get; set; }

            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            public string ServiceRegionId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the domain name of the nearest endpoint that is associated with the endpoint service is resolved first. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The zones to which the service resources belong.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
