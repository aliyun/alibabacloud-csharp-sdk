// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesRequest : TeaModel {
        /// <summary>
        /// <para>The IP address version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b>: IPv4 type.</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: Dual-stack type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically accept endpoint connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Automatically accept endpoint connections.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not automatically accept endpoint connections.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>1000</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Leave this parameter empty for the first query or when no further results exist.</para>
        /// </description></item>
        /// <item><description><para>If another query is needed, set this parameter to the NextToken value returned in the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the endpoint service is deployed.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the service resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-hp32z1wp5peaoox2q****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The business status of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: The endpoint service is running as expected.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: The endpoint service is locked due to an overdue payment.</para>
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
        /// <para>The ID of the endpoint service.</para>
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
        /// <item><description><para><b>slb</b>: The service resource is a Classic Load Balancer (CLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>alb</b>: The service resource is an Application Load Balancer (ALB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: The service resource is a Network Load Balancer (NLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>gwlb</b>: The service resource is a Gateway Load Balancer (GWLB) instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        /// <summary>
        /// <para>The status of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The endpoint service is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: The endpoint service is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: The endpoint service is available.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The endpoint service is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesRequestTag> Tag { get; set; }
        public class ListVpcEndpointServicesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. You can specify up to 20 tag keys. The key cannot be an empty string.</para>
            /// <para>The key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. You can specify up to 20 tag values. The value can be an empty string.</para>
            /// <para>The value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether zonal affinity is enabled for domain name resolution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
