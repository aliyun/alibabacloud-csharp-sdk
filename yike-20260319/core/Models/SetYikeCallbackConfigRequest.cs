// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SetYikeCallbackConfigRequest : TeaModel {
        /// <summary>
        /// <para>The callback configuration. CallbackEventList supports multiple events, including:</para>
        /// <list type="bullet">
        /// <item><description>EventType: the event type. Valid values:<list type="bullet">
        /// <item><description>UserCreated: The user is created.</description></item>
        /// <item><description>UserCreditAdded: Credits are added to the user.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>UserData: a JSON object that contains user-defined data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallbackEventList&quot;:[{&quot;EventType&quot;:&quot;UserCreditAdded&quot;,&quot;UserData&quot;:&quot;{}&quot;}]}</para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfig { get; set; }

        /// <summary>
        /// <para>The HTTP callback URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http//example.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

    }

}
