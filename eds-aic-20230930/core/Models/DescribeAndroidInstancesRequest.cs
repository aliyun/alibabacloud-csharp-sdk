// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("AndroidInstanceName")]
        [Validation(Required=false)]
        public string AndroidInstanceName { get; set; }

        [NameInMap("AppManagePolicyId")]
        [Validation(Required=false)]
        public string AppManagePolicyId { get; set; }

        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public string AuthorizedUserId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/2807298.html">DescribeRegions</a> operation to query the regions where Cloud Phone is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-25nt4kk9whjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the instance groups.</para>
        /// </summary>
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceGroupName")]
        [Validation(Required=false)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the bound key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kp-5hh431emkpuoi****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the parameter is left empty, the data is queried from the first entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kw9dGL5jves2FS9RLq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_id</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The name of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("OfficeSiteIds")]
        [Validation(Required=false)]
        public List<string> OfficeSiteIds { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("QosRuleIds")]
        [Validation(Required=false)]
        public List<string> QosRuleIds { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance: the standard mode.</description></item>
        /// <item><description>Node: the node mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>The state of the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BACKUPING: The instance is being backed up.</description></item>
        /// <item><description>STARTING: The instance is being started.</description></item>
        /// <item><description>RUNNING: The instance group is available.</description></item>
        /// <item><description>DELETING: The instance is being deleted.</description></item>
        /// <item><description>BACKUP_FAILED: The backup operation failed.</description></item>
        /// <item><description>DELETED: The instance is deleted.</description></item>
        /// <item><description>FAILED: The instance failed to be created.</description></item>
        /// <item><description>STOPPED: The instance is stopped.</description></item>
        /// <item><description>RECOVERING: The instance has an ongoing file recovery task.</description></item>
        /// <item><description>UNAVAILABLE: The instance has an exception.</description></item>
        /// <item><description>REBOOTING: The instance is being restarted.</description></item>
        /// <item><description>RESETTING: The instance is being reset.</description></item>
        /// <item><description>STOPPING: The instance is being stopped.</description></item>
        /// <item><description>RECOVER_FAILED: The file recovery task failed.</description></item>
        /// <item><description>CREATING: The instance is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the resources.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesRequestTag> Tag { get; set; }
        public class DescribeAndroidInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
