// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestComponents> Components { get; set; }
        public class CreateApplicationRequestComponents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentMaxReplica")]
            [Validation(Required=false)]
            public long? ComponentMaxReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentReplica")]
            [Validation(Required=false)]
            public long? ComponentReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-********************</para>
            /// </summary>
            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public string SecurityGroups { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestEndpoints> Endpoints { get; set; }
        public class CreateApplicationRequestEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>my_endpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pcs-********************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
