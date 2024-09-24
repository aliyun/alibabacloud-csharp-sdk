// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBProxyInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

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
        /// <para>The specific point in time when you want to perform the upgrade. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> If you set <b>UpgradeTime</b> to <b>SpecifyTime</b>, you must specify SwitchTime.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The time when you want to upgrade the database proxy version of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MaintainTime</b> (default): performs the upgrade during the maintenance window that you specified. For more information, see <a href="https://help.aliyun.com/document_detail/610402.html">Modify the maintenance window</a>.</description></item>
        /// <item><description><b>Immediate</b>: performs the upgrade immediately.</description></item>
        /// <item><description><b>SpecifyTime</b>: performs the upgrade at a specified point in time.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>If the instance runs MySQL, you can set this parameter to <b>MaintainTime</b>, <b>Immediate</b>, or SpecifyTime</b>.</description></item>
        /// <item><description>If the instance runs PostgreSQL, you can set this parameter to <b>MaintainTime</b> or <b>Immediate</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
