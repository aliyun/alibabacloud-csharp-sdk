// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables the feature. You must make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If your account balance is insufficient, you can set AutoPay to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The type of the change that you want to perform on the instance. Valid values:</para>
        /// <remarks>
        /// <para> This parameter is optional. The system can automatically determine whether the instance change is an upgrade or a downgrade. If you want to specify this parameter, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b> (default): upgrades the instance type. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>Down</b>: downgrades the instance type. If the new instance type specified by InstanceType has lower specifications than the current instance type, set Direction to Down.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and resource inventory.</description></item>
        /// <item><description><b>false</b>: performs a dry run and performs the actual request. If the request passes the dry run, the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new instance type. For more information about the instance types that are supported by RDS Custom instances, see <a href="https://help.aliyun.com/document_detail/2844823.html">Instance types of RDS Custom instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.i8.large.2cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public string RebootTime { get; set; }

        [NameInMap("RebootWhenFinished")]
        [Validation(Required=false)]
        public bool? RebootWhenFinished { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hagnzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
