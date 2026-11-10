// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetForgetPasswordConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The list of authentication channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>email: Email.</description></item>
        /// <item><description>sms: SMS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>email</para>
        /// </summary>
        [NameInMap("AuthenticationChannels")]
        [Validation(Required=false)]
        public List<string> AuthenticationChannels { get; set; }

        /// <summary>
        /// <para>The forgot password configuration status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ForgetPasswordStatus")]
        [Validation(Required=false)]
        public string ForgetPasswordStatus { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eiam-111ccc1111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
