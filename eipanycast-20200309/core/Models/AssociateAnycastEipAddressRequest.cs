// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class AssociateAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-bp1ix34fralt4ykf3****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The association mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Default</b>: the default mode. In this mode, the endpoint to be associated serves as the default origin server.</description></item>
        /// <item><description><b>Normal</b>: the standard mode. In this mode, the endpoint to be associated serves as a standard origin server.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can associate endpoints in multiple regions with an Anycast EIP. However, only one endpoint can serve as the default origin server. Others serve as standard origin servers. If you do not specify or add an access point, requests are forwarded to the default origin server.\</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If this is your first time to associate an Anycast EIP with an endpoint, set the value to <b>Default</b>.</description></item>
        /// <item><description>If not, you can also set the value to <b>Default</b>, which specifies a new default origin server. In this case, the previous origin server functions as a standard origin server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint with which you want to associate the Anycast EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-d7oxbixhxv1uupnon****</para>
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the endpoint is deployed.</para>
        /// <para>You can associate Anycast EIPs only with endpoints in specific regions. You can call the <a href="https://help.aliyun.com/document_detail/171939.html">DescribeAnycastServerRegions</a> operation to query the region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>us-west-1</para>
        /// </summary>
        [NameInMap("BindInstanceRegionId")]
        [Validation(Required=false)]
        public string BindInstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of endpoint with which you want to associate the Anycast EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SlbInstance</b>: internal-facing Server Load Balancer (SLB) instance that is deployed in a virtual private cloud (VPC)</description></item>
        /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SlbInstance</para>
        /// </summary>
        [NameInMap("BindInstanceType")]
        [Validation(Required=false)]
        public string BindInstanceType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The information about the access points in associated access areas when you associate an Anycast EIP with an endpoint.</para>
        /// <para>If this is your first time to associate an Anycast EIP with an endpoint, ignore this parameter. The system automatically associates all access areas.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/171938.html">DescribeAnycastPopLocations</a> operation to query information about access points in supported access areas.</para>
        /// </summary>
        [NameInMap("PopLocations")]
        [Validation(Required=false)]
        public List<AssociateAnycastEipAddressRequestPopLocations> PopLocations { get; set; }
        public class AssociateAnycastEipAddressRequestPopLocations : TeaModel {
            /// <summary>
            /// <para>The information about the access points in associated access areas when you associate an Anycast EIP with an endpoint.</para>
            /// <para>If this is your first time to associate an Anycast EIP with an endpoint, ignore this parameter. The system automatically associates all access areas.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/171938.html">DescribeAnycastPopLocations</a> operation to query information about access points in supported access areas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1-pop</para>
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        /// <summary>
        /// <para>The secondary private IP address of the ENI with which you want to associate the Anycast EIP.</para>
        /// <para>This parameter is valid only when you set <b>BindInstanceType</b> to <b>NetworkInterface</b>. If you do not set this parameter, the primary private IP address of the ENI is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

    }

}
