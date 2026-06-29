// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckResourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>Check user resource permission</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckCommand")]
        [Validation(Required=false)]
        public CheckResourcePermissionRequestCheckCommand CheckCommand { get; set; }
        public class CheckResourcePermissionRequestCheckCommand : TeaModel {
            /// <summary>
            /// <para>Operation type</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>Permission resource list</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<CheckResourcePermissionRequestCheckCommandResourceList> ResourceList { get; set; }
            public class CheckResourcePermissionRequestCheckCommandResourceList : TeaModel {
                /// <summary>
                /// <para>Resource ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hadoop.300000806.data_distill.behavior_gameinfor_01</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

            /// <summary>
            /// <para>Resource type</para>
            /// <list type="bullet">
            /// <item><description>PHYSICAL_TABLE: Physical table</description></item>
            /// <item><description>PHYSICAL_FIELD: Physical table field</description></item>
            /// <item><description>LOGICAL_TABLE: Fact logical table</description></item>
            /// <item><description>LOGICAL_FIELD: Fact logical table field</description></item>
            /// <item><description>LABEL_TABLE: Label logical table</description></item>
            /// <item><description>LABEL_FIELD: Label logical table field</description></item>
            /// <item><description>DATASOURCE: Data source</description></item>
            /// <item><description>GLOBAL_PARAM: Global parameter</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: Real-time meta table</description></item>
            /// <item><description>REALTIME_LOGICAL_FIELD: Real-time meta table field</description></item>
            /// <item><description>REALTIME_MIRROR_TABLE: Mirror table</description></item>
            /// <item><description>REALTIME_MIRROR_FIELD: Real-time mirror table field</description></item>
            /// <item><description>FUNCTION: Function</description></item>
            /// <item><description>FEATURE: Feature permission</description></item>
            /// <item><description>PHYSICAL_VIEW: Physical view</description></item>
            /// <item><description>LOGICAL_VIEW: Logical view</description></item>
            /// <item><description>QD_SERVICE_FEATURE: Service tag</description></item>
            /// <item><description>QD_ADVANCED_FEATURE: Advanced tag</description></item>
            /// <item><description>QD_CLUSTER: Group</description></item>
            /// <item><description>QD_EVENT: Event</description></item>
            /// <item><description>QD_OFFLINE_SERVICE: Tag offline service task</description></item>
            /// <item><description>PHYSICAL_MATERIALIZED_VIEW: Materialized view</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICAL_TABLE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323231</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
