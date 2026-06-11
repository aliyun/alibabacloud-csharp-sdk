// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class EnableVpcEndpointConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth of the endpoint connection. Unit: Mbit/s.</para>
        /// <remarks>
        /// <para>The valid values vary depending on the service resource type:</para>
        /// <list type="bullet">
        /// <item><description>NLB: 100 to 50000.</description></item>
        /// <item><description>ALB: 100 to 25000.</description></item>
        /// <item><description>CLB: 100 to 10240. Default value: 3072.</description></item>
        /// <item><description>GWLB: 100 to 25000.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3072</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. <b>ClientToken</b> can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing required parameters, the request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the connection request is accepted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint connection to be accepted.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The endpoint service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Scalability: automatic scaling. In this mode, the connection bandwidth configured for the endpoint connection does not take effect.</para>
        /// </description></item>
        /// <item><description><para>BandwidthLimit: supports setting a bandwidth upper limit for the endpoint connection. The bandwidth upper limit is the value of Bandwidth.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When the service resource is NLB, TrafficControlMode is set to Scalability by default. You can set it to BandwidthLimit and modify the value of Bandwidth to provide a bandwidth upper limit.</description></item>
        /// <item><description>When the service resource is CLB, TrafficControlMode can only be set to BandwidthLimit, which indicates that the service provider provides default bandwidth throttling for each endpoint.</description></item>
        /// <item><description>When the service resource is GWLB, TrafficControlMode can only be set to Scalability.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthLimit</para>
        /// </summary>
        [NameInMap("TrafficControlMode")]
        [Validation(Required=false)]
        public string TrafficControlMode { get; set; }

    }

}
