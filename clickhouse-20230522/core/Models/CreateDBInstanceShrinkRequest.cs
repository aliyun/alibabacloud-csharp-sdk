// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateDBInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>enterprise</c>: Enterprise Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>A client-provided token to ensure request idempotence. It must be unique across requests, contain only ASCII characters, and not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The time zone of the database, which must be an IANA time zone identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("DBTimeZone")]
        [Validation(Required=false)]
        public string DBTimeZone { get; set; }

        /// <summary>
        /// <para>The deployment mode of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>multi_az</para>
        /// </summary>
        [NameInMap("DeploySchema")]
        [Validation(Required=false)]
        public string DeploySchema { get; set; }

        /// <summary>
        /// <para>The engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23.8</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The multi-zone configuration.</para>
        /// </summary>
        [NameInMap("MultiZone")]
        [Validation(Required=false)]
        public string MultiZoneShrink { get; set; }

        /// <summary>
        /// <para>The number of nodes. Valid values: 2 to 16. This parameter is required when you configure an elastic scaling range by using the <c>NodeScaleMin</c> and <c>NodeScaleMax</c> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>The maximum number of nodes for serverless elastic scaling. Valid values: 4 to 32. The value must be greater than the <c>NodeScaleMin</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NodeScaleMax")]
        [Validation(Required=false)]
        public int? NodeScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum number of nodes for serverless elastic scaling. Valid values: 4 to 32.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("NodeScaleMin")]
        [Validation(Required=false)]
        public int? NodeScaleMin { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Use the <c>NodeCount</c>, <c>NodeScaleMin</c>, and <c>NodeScaleMax</c> parameters to configure elastic scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Use the <c>NodeCount</c>, <c>NodeScaleMin</c>, and <c>NodeScaleMax</c> parameters to configure elastic scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The ID of the source instance. This parameter is required when restoring from a backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze1*********</para>
        /// </summary>
        [NameInMap("SourceDBInstanceId")]
        [Validation(Required=false)]
        public string SourceDBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageQuota")]
        [Validation(Required=false)]
        public long? StorageQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tags to add to the instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateDBInstanceShrinkRequestTags> Tags { get; set; }
        public class CreateDBInstanceShrinkRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_123</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example string</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6xmupdn7v6ui9f****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf632qye9oqt4x4sr****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
