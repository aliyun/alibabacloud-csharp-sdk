// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchToPrimaryInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-7xv8f2zcia0e4****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: Executes immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: Executes within the maintenance window.</description></item>
        /// </list>
        /// <para>Default value: <b>Immediate</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The switchover mode. Valid values:</para>
        /// <para><b>true</b>: Forced switchover.</para>
        /// <para><b>false</b>: Normal switchover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceSwitch")]
        [Validation(Required=false)]
        public bool? ForceSwitch { get; set; }

    }

}
