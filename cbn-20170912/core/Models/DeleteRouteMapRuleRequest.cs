// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteRouteMapRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value from your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request and does not delete the route map rule. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the check, the corresponding error is returned. If the request passes the check, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a regular request and directly deletes the route map rule after the request passes the check.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the route map rule to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmr-0a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("RouteMapRuleId")]
        [Validation(Required=false)]
        public string RouteMapRuleId { get; set; }

    }

}
