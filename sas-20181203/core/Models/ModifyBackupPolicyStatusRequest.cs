// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyBackupPolicyStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware policy that you want to enable or shutdown.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30490</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The version of the policy that you want to enable or disable. Set the value to <b>2.0.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        [Obsolete]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the anti-ransomware policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enables the anti-ransomware policy. After the policy is enabled, anti-ransomware can protect your server data by backing up data on specified servers based on your anti-ransomware policy.</description></item>
        /// <item><description><b>disabled</b>: Disables the anti-ransomware policy. After the policy is disabled, running backup tasks are stopped.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Backup tasks consume network bandwidth. Enable the policy during off-peak hours to execute data backup tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
