// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEventCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication key. This parameter is returned only for HTTP callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKey001</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether callback authentication is enabled. This parameter is returned only for <b>HTTP</b> callbacks. Valid values:</para>
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
        /// <para>The name of the Simple Message Queue (SMQ) queue to which callback messages are sent.</para>
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
        /// <para>The callback URL to which event notifications are sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx.yyy/callback">http://xxx.yyy/callback</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>The type of the callback event. Multiple values are separated with commas (,). For more information about callback event types, see <a href="https://help.aliyun.com/document_detail/610204.html">Event notification content</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProduceMediaComplete,TranscodeComplete</para>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
