// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncResultRequest : TeaModel {
        /// <summary>
        /// <para>The moderation service to run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio_security_check</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters for the moderation service, provided as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;taskId&quot;: &quot;au_f_xxxxx&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
