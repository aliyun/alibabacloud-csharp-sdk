// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordHistoryConfigurationRequest : TeaModel {
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
        /// <para>The number of recent password records to retain. This parameter is required when PasswordHistoryStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PasswordHistoryMaxRetention")]
        [Validation(Required=false)]
        public int? PasswordHistoryMaxRetention { get; set; }

        /// <summary>
        /// <para>The status of the password history configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordHistoryStatus")]
        [Validation(Required=false)]
        public string PasswordHistoryStatus { get; set; }

    }

}
