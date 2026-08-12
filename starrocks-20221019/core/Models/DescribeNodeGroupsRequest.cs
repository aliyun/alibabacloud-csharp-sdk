// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeNodeGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-718fb04c7112****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The page number for paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The compute group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FE</description></item>
        /// <item><description>BE</description></item>
        /// <item><description>CN</description></item>
        /// <item><description>OBSERVER</description></item>
        /// <item><description>AGENT</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FE</para>
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The instance ID. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of compute group IDs to query.</para>
        /// </summary>
        [NameInMap("nodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        /// <summary>
        /// <para>The compute group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng_1</para>
        /// </summary>
        [NameInMap("nodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The compute group status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNPAID: Unpaid.</description></item>
        /// <item><description>PAID: Paid.</description></item>
        /// <item><description>CREATING_FAILED: Creation failed.</description></item>
        /// <item><description>CREATING: Being created.</description></item>
        /// <item><description>RUNNING: Running.</description></item>
        /// <item><description>MODIFYING_CONFIG: Configuration being modified.</description></item>
        /// <item><description>MODIFYING_TIMEZONE: Time zone being modified.</description></item>
        /// <item><description>ELASTIC_SCALING_OUT: Elastic scale-out in progress.</description></item>
        /// <item><description>ELASTIC_SCALING_IN: Elastic scale-in in progress.</description></item>
        /// <item><description>SCALING_OUT: Scale-out in progress.</description></item>
        /// <item><description>RESTARTING: Restarting.</description></item>
        /// <item><description>SCALING_IN: Scale-in in progress.</description></item>
        /// <item><description>SCALING_UP: Upgrading specifications.</description></item>
        /// <item><description>SCALING_DOWN: Downgrading specifications.</description></item>
        /// <item><description>UPGRADING: Upgrading.</description></item>
        /// <item><description>ENABLE_PUBLIC_NETWORK: Enabling public network access.</description></item>
        /// <item><description>DISABLE_PUBLIC_NETWORK: Disabling public network access.</description></item>
        /// <item><description>SWITCH_AZ: Switching zone.</description></item>
        /// <item><description>DISABLE: Disabled.</description></item>
        /// <item><description>DELETING: Being deleted.</description></item>
        /// <item><description>DELETED: Deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<DescribeNodeGroupsRequestTags> Tags { get; set; }
        public class DescribeNodeGroupsRequestTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
