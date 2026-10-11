// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class DeleteEgressProxyGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value of this parameter on the client side. Make sure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>Note: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends a check request and does not delete the egress proxy gateway instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the check fails, the system returns an error. If the check succeeds, the system returns the error code DryRunOperation.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a regular request. If the check succeeds, the system returns an HTTP 2xx status code and performs the operation.</para>
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
        /// <para>The ID of the egress proxy gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayId")]
        [Validation(Required=false)]
        public string EgressProxyGatewayId { get; set; }

    }

}
