// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SetYikeCallbackConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallbackEventList&quot;:[{&quot;EventType&quot;:&quot;UserCreditAdded&quot;,&quot;UserData&quot;:&quot;{}&quot;}]}</para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfig { get; set; }

        /// <summary>
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
