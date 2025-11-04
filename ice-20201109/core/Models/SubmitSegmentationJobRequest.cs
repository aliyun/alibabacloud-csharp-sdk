// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSegmentationJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input configuration. For detailed parameters, see <a href="~~2874121#cc59ad3082jbx~~">InputConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Type&quot;: &quot;OSS&quot;,
        ///     &quot;Media&quot;: &quot;<a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4">http://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4</a>&quot;
        /// }
        /// or {
        ///     &quot;Type&quot;: &quot;Media&quot;,
        ///     &quot;Media&quot;: &quot;ce49a020e****1ef81c1e6f6d5686302&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The task parameters. For details, see <a href="~~2874121#a60357f2d5iix~~">JobParams</a>.</para>
        /// 
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
        /// <para>The output configuration. For detailed parameters, see <a href="~~2874121#cef23186a8d6w~~">OutputConfig</a>.</para>
        /// 
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

        /// <summary>
        /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;: &quot;22&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
