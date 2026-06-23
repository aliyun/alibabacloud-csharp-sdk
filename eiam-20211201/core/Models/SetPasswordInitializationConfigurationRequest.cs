// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordInitializationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The password forced update status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordForcedUpdateStatus")]
        [Validation(Required=false)]
        public string PasswordForcedUpdateStatus { get; set; }

        /// <summary>
        /// <para>The list of password initialization notification channels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>email</para>
        /// </summary>
        [NameInMap("PasswordInitializationNotificationChannels")]
        [Validation(Required=false)]
        public List<string> PasswordInitializationNotificationChannels { get; set; }

        /// <summary>
        /// <para>The password initialization configuration status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordInitializationStatus")]
        [Validation(Required=false)]
        public string PasswordInitializationStatus { get; set; }

        /// <summary>
        /// <para>The password initialization method. This parameter is required when PasswordInitializationStatus is set to enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>random: Random.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>random</para>
        /// </summary>
        [NameInMap("PasswordInitializationType")]
        [Validation(Required=false)]
        public string PasswordInitializationType { get; set; }

    }

}
