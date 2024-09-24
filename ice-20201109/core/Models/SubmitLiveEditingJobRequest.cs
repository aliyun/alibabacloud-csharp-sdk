// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; ,  &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;},  {\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:05:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:09:00Z\&quot; }]</para>
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public string Clips { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;  }</para>
        /// </summary>
        [NameInMap("LiveStreamConfig")]
        [Validation(Required=false)]
        public string LiveStreamConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;Mode&quot;: &quot;AccurateFast&quot;}</para>
        /// </summary>
        [NameInMap("MediaProduceConfig")]
        [Validation(Required=false)]
        public string MediaProduceConfig { get; set; }

        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
