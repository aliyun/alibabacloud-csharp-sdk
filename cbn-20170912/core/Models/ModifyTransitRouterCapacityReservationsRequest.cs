// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouterCapacityReservationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public List<ModifyTransitRouterCapacityReservationsRequestDeploymentSets> DeploymentSets { get; set; }
        public class ModifyTransitRouterCapacityReservationsRequestDeploymentSets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-badxcs*****</para>
            /// </summary>
            [NameInMap("DeploymentSetID")]
            [Validation(Required=false)]
            public string DeploymentSetID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

        }

        [NameInMap("MinimumTransitRouterCapacities")]
        [Validation(Required=false)]
        public List<ModifyTransitRouterCapacityReservationsRequestMinimumTransitRouterCapacities> MinimumTransitRouterCapacities { get; set; }
        public class ModifyTransitRouterCapacityReservationsRequestMinimumTransitRouterCapacities : TeaModel {
            [NameInMap("DataProcessGbps")]
            [Validation(Required=false)]
            public ModifyTransitRouterCapacityReservationsRequestMinimumTransitRouterCapacitiesDataProcessGbps DataProcessGbps { get; set; }
            public class ModifyTransitRouterCapacityReservationsRequestMinimumTransitRouterCapacitiesDataProcessGbps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-l</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ResetCapacityReservations")]
        [Validation(Required=false)]
        public List<ModifyTransitRouterCapacityReservationsRequestResetCapacityReservations> ResetCapacityReservations { get; set; }
        public class ModifyTransitRouterCapacityReservationsRequestResetCapacityReservations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

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
