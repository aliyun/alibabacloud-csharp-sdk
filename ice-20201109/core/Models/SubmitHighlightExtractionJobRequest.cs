// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitHighlightExtractionJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;MediaArray&quot;: [{
        ///         &quot;MediaId&quot;: &quot;ceb72f00e<b><b>1ef8216e7e6c64a6302&quot;
        ///     }, {
        ///         &quot;MediaId&quot;: &quot;ce450c40e</b></b>1ef8216e7e6c64a6302&quot;
        ///     }, {
        ///         &quot;MediaId&quot;: &quot;ce49a020e<b><b>1ef81c1e6f6d5686302&quot;
        ///     }, {
        ///         &quot;MediaId&quot;: &quot;d047e120e</b></b>1ef81c1e6f6d5686302&quot;
        ///     }, {
        ///         &quot;MediaId&quot;: &quot;cfe2ddc0e****1ef81c1e6f6d5686302&quot;
        ///     }],
        ///     &quot;Strategy&quot;: {
        ///         &quot;Count&quot;: 5,
        ///         &quot;ClipDuration&quot;: 15
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;NeedExport&quot;: true,
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

        /// <summary>
        /// <para>The user-defined data, including the business and callback configurations. For more information, see <a href="~~357745#section-urj-v3f-0s1~~">UserData</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
