// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckResourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The user resource permission check command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckCommand")]
        [Validation(Required=false)]
        public CheckResourcePermissionRequestCheckCommand CheckCommand { get; set; }
        public class CheckResourcePermissionRequestCheckCommand : TeaModel {
            /// <summary>
            /// <para>The operation type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>The resources.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<CheckResourcePermissionRequestCheckCommandResourceList> ResourceList { get; set; }
            public class CheckResourcePermissionRequestCheckCommandResourceList : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
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
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PHYSICAL_TABLE: Physical table.</description></item>
            /// <item><description>PHYSICAL_FIELD: Physical table field.</description></item>
            /// <item><description>LOGICAL_TABLE: Logical fact table.</description></item>
            /// <item><description>LOGICAL_FIELD: Logical fact table field.</description></item>
            /// <item><description>LABEL_TABLE: Logical label table.</description></item>
            /// <item><description>LABEL_FIELD: Logical label table field.</description></item>
            /// <item><description>DATASOURCE: Data source.</description></item>
            /// <item><description>GLOBAL_PARAM: Global parameter.</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: Real-time metadata table.</description></item>
            /// <item><description>REALTIME_LOGICAL_FIELD: Real-time metadata table field.</description></item>
            /// <item><description>REALTIME_MIRROR_TABLE: Mirror table.</description></item>
            /// <item><description>REALTIME_MIRROR_FIELD: Real-time mirror table field.</description></item>
            /// <item><description>FUNCTION: Function.</description></item>
            /// <item><description>FEATURE: Feature permission.</description></item>
            /// <item><description>PHYSICAL_VIEW: Physical view.</description></item>
            /// <item><description>LOGICAL_VIEW: Logical view.</description></item>
            /// <item><description>QD_SERVICE_FEATURE: Service label.</description></item>
            /// <item><description>QD_ADVANCED_FEATURE: Advanced label.</description></item>
            /// <item><description>QD_CLUSTER: Group.</description></item>
            /// <item><description>QD_EVENT: Event.</description></item>
            /// <item><description>QD_OFFLINE_SERVICE: Offline label service task.</description></item>
            /// <item><description>PHYSICAL_MATERIALIZED_VIEW: Materialized view.</description></item>
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
            /// <para>The user ID.</para>
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
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
