// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CheckCreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CacheSize")]
        [Validation(Required=false)]
        public int? CacheSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213c8y****-public.selectdbfe.pre.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>selectdb.xlarge</b>: 4 CPU cores and 32 GB of memory.</description></item>
        /// <item><description><b>selectdb.2xlarge</b>: 8 CPU cores and 64 GB of memory.</description></item>
        /// <item><description><b>selectdb.4xlarge</b>: 16 CPU cores and 128 GB of memory.</description></item>
        /// <item><description><b>selectdb.8xlarge</b>: 32 CPU cores and 256 GB of memory.</description></item>
        /// <item><description><b>selectdb.16xlarge</b>: 64 CPU cores and 512 GB of memory.</description></item>
        /// <item><description><b>selectdb.24xlarge</b>: 96 CPU cores and 768 GB of memory.</description></item>
        /// <item><description><b>selectdb.32xlarge</b>: 128 CPU cores and 1,024 GB of memory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb.xlarge</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The database engine of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SelectDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.16.XX.XX/12,192.168.XX.XX/22</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If Period is set to Year, valid values of UsedTime are 1, 2, 3, 4, and 5.</description></item>
        /// <item><description>If Period is set to Month, valid values of UsedTime are 1 to 12.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect and is required only if ChargeType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
