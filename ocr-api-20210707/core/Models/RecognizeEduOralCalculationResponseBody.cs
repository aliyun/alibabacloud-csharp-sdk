// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeEduOralCalculationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;height&quot;:3024,&quot;mathsInfo&quot;:[{&quot;pos&quot;:[{&quot;x&quot;:128,&quot;y&quot;:456},{&quot;x&quot;:481,&quot;y&quot;:425},{&quot;x&quot;:479,&quot;y&quot;:526},{&quot;x&quot;:127,&quot;y&quot;:523}],&quot;result&quot;:&quot;right&quot;,&quot;title&quot;:&quot;5 9 - 2 5 = 3 4&quot;}],&quot;orgHeight&quot;:3024,&quot;orgWidth&quot;:2268,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:0,&quot;prism_wordsInfo&quot;:[],&quot;width&quot;:2268}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
