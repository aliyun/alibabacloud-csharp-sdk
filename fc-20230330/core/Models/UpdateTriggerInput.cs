// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateTriggerInput : TeaModel {
        /// <summary>
        /// <para>The description of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trigger for test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The role that is used by the event source such as object Storage Service (OSS) to invoke the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/fc-test</para>
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// <para>The version or alias of the service to which the function belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The configuration of the trigger. The configuration vary based on the trigger type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;events&quot;:[&quot;oss:ObjectCreated:*&quot;],&quot;filter&quot;:{&quot;key&quot;:{&quot;prefix&quot;:&quot;/prefix&quot;,&quot;suffix&quot;:&quot;.zip&quot;}}}</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

    }

}
