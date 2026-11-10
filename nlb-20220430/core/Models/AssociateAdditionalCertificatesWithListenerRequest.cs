// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class AssociateAdditionalCertificatesWithListenerRequest : TeaModel {
        /// <summary>
        /// <para>The list of additional certificates. You can associate up to 15 additional certificates with a listener in a single call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AdditionalCertificateIds")]
        [Validation(Required=false)]
        public List<string> AdditionalCertificateIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a value for this parameter on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request and does not add the additional certificates to the TCPSSL listener. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the check, the system returns an error. If the request passes the check, the system returns the error code <c>DryRunOperation</c>.</description></item>
        /// <item><description><b>false</b> (default): sends a standard request. If the request passes the check, the system returns an HTTP 2xx status code and performs the operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the listener. This operation only supports TCPSSL listener IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-bpn0kn908w4nbw****@80</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Network Load Balancer (NLB) instance is deployed. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
