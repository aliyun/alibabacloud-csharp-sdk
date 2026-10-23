// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouterCapacityReservationsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public string DeploymentSetsShrink { get; set; }

        [NameInMap("MinimumTransitRouterCapacities")]
        [Validation(Required=false)]
        public string MinimumTransitRouterCapacitiesShrink { get; set; }

        [NameInMap("ResetCapacityReservations")]
        [Validation(Required=false)]
        public string ResetCapacityReservationsShrink { get; set; }

        /// <summary>
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
