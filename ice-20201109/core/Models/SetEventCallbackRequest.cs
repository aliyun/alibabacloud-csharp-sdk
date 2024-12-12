// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetEventCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The authentication key. The key can be up to 32 characters in length and must contain uppercase letters, lowercase letters, and digits. This parameter takes effect only if you set CallbackType to <b>HTTP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKey001</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. This parameter takes effect only if you set CallbackType to <b>HTTP</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AuthSwitch")]
        [Validation(Required=false)]
        public string AuthSwitch { get; set; }

        /// <summary>
        /// <para>The name of the Simple Message Queue (SMQ) queue in the region. The name must start with ice-callback-.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ice-callback-queue</para>
        /// </summary>
        [NameInMap("CallbackQueueName")]
        [Validation(Required=false)]
        public string CallbackQueueName { get; set; }

        /// <summary>
        /// <para>The callback method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>MNS</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// <para>The callback URL. This parameter is required if you set CallbackType to <b>HTTP</b>. The callback URL cannot exceed 256 bytes in length. You can specify only one callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx.yyy/callback">http://xxx.yyy/callback</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>The type of the callback event. You can specify multiple values separated with commas (,). ProduceMediaComplete: indicates that the editing and production task is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProduceMediaComplete</para>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

    }

}
