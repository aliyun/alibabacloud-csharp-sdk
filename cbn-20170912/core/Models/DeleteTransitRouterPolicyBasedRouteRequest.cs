// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteTransitRouterPolicyBasedRouteRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must ensure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the deletion request. The dry run includes permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request. After the request passes the dry run, the policy-based route is deleted.</description></item>
        /// <item><description><b>true</b>: sends a dry run request. The system only performs the dry run and does not delete the policy-based route. The system checks whether required parameters are specified and whether the request format is valid. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the policy-based routing rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pbr-123abczcx</para>
        /// </summary>
        [NameInMap("PolicyBasedRouteId")]
        [Validation(Required=false)]
        public string PolicyBasedRouteId { get; set; }

    }

}
