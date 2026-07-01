// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSportsHighlightsJobRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotency.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input configuration. For more information, see <a href="~~2843158#5cbc796a9cuu8~~">input configuration parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;SportsCategory&quot;: &quot;basketball&quot;,
        ///   &quot;InputMedia&quot;: &quot;<a href="http://test-bucket.oss-cn-******.basketball-0707.mp4">http://test-bucket.oss-cn-******.basketball-0707.mp4</a>&quot;,
        ///   &quot;FaceRegister&quot;: [
        ///     {
        ///       &quot;FaceUrls&quot;: [&quot;<a href="http://testcdn.com/front.jpg">http://testcdn.com/front.jpg</a>&quot;, &quot;<a href="http://testcdn.com/side.jpg%22%5D">http://testcdn.com/side.jpg&quot;]</a>,
        ///       &quot;Name&quot;: &quot;James&quot;
        ///     }
        ///   ],
        ///   &quot;SlowMotionLogoRegister&quot;: {
        ///       &quot;SlowMotionLogoUrls&quot;: [&quot;<a href="http://testcdn.com/logo1.jpg">http://testcdn.com/logo1.jpg</a>&quot;, &quot;<a href="http://testcdn.com/logo2.jpg%22%5D">http://testcdn.com/logo2.jpg&quot;]</a>
        ///   },
        ///   &quot;TransferNameRegister&quot;: [
        ///     {
        ///       &quot;OriginalName&quot;: &quot;IND&quot;,
        ///       &quot;TransferName&quot;: &quot;印第安纳步行者&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configuration. For more information, see <a href="~~2843158#b7dad99fe5q0r~~">output configuration parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
        ///   &quot;Count&quot;: 1,
        ///   &quot;Width&quot;: 1080,
        ///   &quot;Height&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The user data, containing business and callback configurations. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/357745.html">user data configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
