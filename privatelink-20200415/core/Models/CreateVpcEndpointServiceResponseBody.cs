// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the endpoint service is configured to automatically accept endpoint connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The endpoint service automatically accepts endpoint connections.</description></item>
        /// <item><description><b>false</b>: The endpoint service does not automatically accept endpoint connections.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        /// <summary>
        /// <para>The time when the endpoint service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T19:11:12Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>The business status of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: financial lock.</para>
        /// </description></item>
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
        /// <para>The service domain name of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****.cn-huhehaote.privatelink.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceDomain")]
        [Validation(Required=false)]
        public string ServiceDomain { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service name of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The endpoint service status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: being created.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
        /// </description></item>
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
        /// <para>Indicates whether the endpoint service supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not supported.</para>
        /// </description></item>
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
        /// <para>The list of regions supported by the endpoint service. Service consumers can initiate endpoint connections from the regions in the list.</para>
        /// </summary>
        [NameInMap("SupportedRegionSet")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointServiceResponseBodySupportedRegionSet> SupportedRegionSet { get; set; }
        public class CreateVpcEndpointServiceResponseBodySupportedRegionSet : TeaModel {
            /// <summary>
            /// <para>The business status of the region supported by the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: normal.</description></item>
            /// <item><description><b>FinancialLocked</b>: financial lock.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("RegionBusinessStatus")]
            [Validation(Required=false)]
            public string RegionBusinessStatus { get; set; }

            /// <summary>
            /// <para>The status of the region supported by the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: being modified.</description></item>
            /// <item><description><b>Available</b>: available.</description></item>
            /// <item><description><b>Deleting</b>: being deleted.</description></item>
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// <item><description><b>Closed</b>: closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("RegionServiceStatus")]
            [Validation(Required=false)]
            public string RegionServiceStatus { get; set; }

            /// <term><b>Obsolete</b></term>
            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ServiceRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the region supported by the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SupportedRegionId")]
            [Validation(Required=false)]
            public string SupportedRegionId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether zone affinity is supported for the endpoint domain name of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: supported.</description></item>
        /// <item><description><b>false</b>: not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
