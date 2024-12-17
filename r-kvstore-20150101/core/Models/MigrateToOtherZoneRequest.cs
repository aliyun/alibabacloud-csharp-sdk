// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraDB for Redis instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies the time when the database is switched after data is migrated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: immediately switched after the data is migrated.</description></item>
        /// <item><description><b>MaintainTime</b>: switched within the maintenance window.</description></item>
        /// <item><description><b>0</b>: immediately switched after the data is migrated.</description></item>
        /// <item><description><b>1</b>: switched within the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: <b>Immediately</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the destination secondary zone. You can call the <a href="~~DescribeZones~~">DescribeZones</a> operation to query zone IDs.</para>
        /// <remarks>
        /// <para> You can specify this parameter to deploy the master node and replica node in different zones to implement zone-disaster recovery. This helps withstand data center-level breakdowns.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The vSwitch must be deployed in the zone that is specified by the ZoneId parameter.</description></item>
        /// <item><description>If the network type of the instance is VPC, this parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination primary zone. You can call the <a href="https://help.aliyun.com/document_detail/94527.html">DescribeZones</a> operation to query zone IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
