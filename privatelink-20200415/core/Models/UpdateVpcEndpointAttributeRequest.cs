// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.<remarks>
        /// <para>To enable dual-stack for the endpoint, the endpoint service connected to the endpoint and the VPC in which the endpoint resides must both support dual-stack.</para>
        /// </remarks>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cross-region bandwidth. This parameter is required only when the endpoint and the endpoint service are in different regions. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Minimum value</b>: 100.</description></item>
        /// <item><description><b>Maximum value</b>: limited by the quota of the current account. For more information, see <a href="https://www.alibabacloud.com/help/en/privatelink/quotas-and-limits">Quotas and limits</a>.<remarks>
        /// <para>Before you specify this parameter, make sure that the endpoint is a cross-region endpoint.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CrossRegionBandwidth")]
        [Validation(Required=false)]
        public int? CrossRegionBandwidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request without performing the update gateway endpoint attribute operation. The system checks the request for potential issues, including missing parameter values, incorrect request format, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the endpoint.</para>
        /// <para>The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Endpoint.</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). The name must start with a letter or a Chinese character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The RAM access policy. For more information about the policy definition, see <a href="https://help.aliyun.com/document_detail/93738.html">Policy elements</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Version&quot;: &quot;1&quot;,
        ///   &quot;Statement&quot;: [
        ///     {
        ///       &quot;Effect&quot;: &quot;Allow&quot;,
        ///       &quot;Action&quot;: [
        ///         &quot;oss:List*&quot;,
        ///         &quot;oss:PutObject&quot;,
        ///         &quot;oss:GetObject&quot;
        ///       ],
        ///       &quot;Resource&quot;: [
        ///         &quot;acs:oss:oss-<em>:</em>:pvl-policy-test/policy-test.txt&quot;
        ///       ],
        ///       &quot;Principal&quot;: {
        ///         &quot;RAM&quot;: [
        ///           &quot;acs:ram::14199xxxxxx:*&quot;
        ///         ]
        ///       }
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint that you want to modify. You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eu-west-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resets the policy to the default policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResetPolicy")]
        [Validation(Required=false)]
        public bool? ResetPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable nearest access for the endpoint domain name of the connected service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
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
