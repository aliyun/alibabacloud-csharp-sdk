// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouterCapacityReservationsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the token on your client to ensure that the token is unique across different requests. The client token only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID of the API request as the client token. The request ID may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment set information for the capacity reservation.</para>
        /// </summary>
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public string DeploymentSetsShrink { get; set; }

        /// <summary>
        /// <para>The reserved capacity for each zone in the capacity reservation.</para>
        /// </summary>
        [NameInMap("MinimumTransitRouterCapacities")]
        [Validation(Required=false)]
        public string MinimumTransitRouterCapacitiesShrink { get; set; }

        /// <summary>
        /// <para>Cancels capacity reservations.</para>
        /// </summary>
        [NameInMap("ResetCapacityReservations")]
        [Validation(Required=false)]
        public string ResetCapacityReservationsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the transit router instance for forward routing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
