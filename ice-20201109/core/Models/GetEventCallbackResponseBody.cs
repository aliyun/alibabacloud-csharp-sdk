// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEventCallbackResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TestKey001</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AuthSwitch")]
        [Validation(Required=false)]
        public string AuthSwitch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ice-callback-queue</para>
        /// </summary>
        [NameInMap("CallbackQueueName")]
        [Validation(Required=false)]
        public string CallbackQueueName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx.yyy/callback">http://xxx.yyy/callback</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProduceMediaComplete,TranscodeComplete</para>
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
