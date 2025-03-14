// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSegmentationJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Mode&quot;: &quot;UserDefined&quot;,
        ///     &quot;Ranges&quot;: [{
        ///         &quot;In&quot;: 10,
        ///         &quot;Out&quot;: 20
        ///     }, {
        ///         &quot;In&quot;: 35,
        ///         &quot;Out&quot;: 50
        ///     }]
        /// }</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;OutputMediaTarget&quot;: &quot;oss-object&quot;,
        ///     &quot;Bucket&quot;: &quot;test-bucket&quot;,
        ///     &quot;ObjectKey&quot;: &quot;path/to/test_{index}.mp4&quot;,
        ///     &quot;Width&quot;: 1920,
        ///     &quot;Height&quot;: 1080,
        ///     &quot;ExportAsNewMedia&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
