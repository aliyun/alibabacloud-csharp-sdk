// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateHttpEventConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;switchFlag&quot;: true,
        ///     &quot;callbackUrl&quot;: &quot;<a href="http://123213.com">http://123213.com</a>&quot;,
        ///     &quot;httpMethod&quot;: &quot;GET&quot;,
        ///     &quot;eventConfig&quot;: {
        ///         &quot;taskCompleteEvent&quot;: true,
        ///         &quot;fileReviewedEvent&quot;: true,
        ///         &quot;complaintHandledEvent&quot;: true
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
