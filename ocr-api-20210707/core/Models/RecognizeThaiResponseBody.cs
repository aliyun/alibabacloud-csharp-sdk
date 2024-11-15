// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeThaiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;angle&quot;:0,&quot;content&quot;:&quot;4สัป าR  ๗  เริมเห็นผิวที่เรียบเบียน  วิรีการใช้ LEshop uA&quot;,&quot;height&quot;:887,&quot;orgHeight&quot;:887,&quot;orgWidth&quot;:790,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:26,&quot;prism_wordsInfo&quot;:[{&quot;angle&quot;:-89,&quot;direction&quot;:0,&quot;height&quot;:210,&quot;pos&quot;:[{&quot;x&quot;:285,&quot;y&quot;:14},{&quot;x&quot;:495,&quot;y&quot;:14},{&quot;x&quot;:495,&quot;y&quot;:63},{&quot;x&quot;:285,&quot;y&quot;:63}],&quot;prob&quot;:85,&quot;width&quot;:48,&quot;word&quot;:&quot;4สัป าR &quot;,&quot;x&quot;:365,&quot;y&quot;:-66}],&quot;width&quot;:790}</para>
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
