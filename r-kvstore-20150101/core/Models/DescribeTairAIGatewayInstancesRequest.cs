// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairAIGatewayInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The expiration status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance has expired.</description></item>
        /// <item><description><b>false</b>: The instance has not expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>The IDs of the instances to query.</para>
        /// <remarks>
        /// <para>Separate multiple instance IDs with commas (,). You can specify up to 30 instance IDs in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tg-2zezxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The instance is running.</description></item>
        /// <item><description><b>Creating</b>: The instance is being created.</description></item>
        /// <item><description><b>Changing</b>: The instance is being modified.</description></item>
        /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
        /// <item><description><b>Flushing</b>: The instance data is being purged.</description></item>
        /// <item><description><b>Released</b>: The instance is released.</description></item>
        /// <item><description><b>Transforming</b>: The instance is being transformed.</description></item>
        /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
        /// <item><description><b>BackupRecovering</b>: The instance is recovering from a backup.</description></item>
        /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being upgraded.</description></item>
        /// <item><description><b>NetworkModifying</b>: The network of the instance is being modified.</description></item>
        /// <item><description><b>SSLModifying</b>: The SSL configuration of the instance is being modified.</description></item>
        /// <item><description><b>MajorVersionUpgrading</b>: A major engine version upgrade is in progress. The instance remains accessible.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about instance statuses and impacts, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance statuses and impacts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy search is supported for instance names or instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query the vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
