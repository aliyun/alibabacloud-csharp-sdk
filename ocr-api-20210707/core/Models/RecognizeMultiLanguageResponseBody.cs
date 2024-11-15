// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeMultiLanguageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;PACKING  Shipper/Export   Invoice No &amp; Date  STM TECHNOLOGY INC. 20140730- ST44 &quot;,&quot;height&quot;:1753,&quot;orgHeight&quot;:1753,&quot;orgWidth&quot;:1240,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:71,&quot;prism_wordsInfo&quot;:[{&quot;angle&quot;:0,&quot;direction&quot;:0,&quot;height&quot;:33,&quot;pos&quot;:[{&quot;x&quot;:348,&quot;y&quot;:137},{&quot;x&quot;:531,&quot;y&quot;:135},{&quot;x&quot;:532,&quot;y&quot;:168},{&quot;x&quot;:348,&quot;y&quot;:170}],&quot;prob&quot;:99,&quot;recClassify&quot;:1,&quot;width&quot;:184,&quot;word&quot;:&quot;PACKING&quot;,&quot;x&quot;:348,&quot;y&quot;:135}],&quot;width&quot;:1240}</para>
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
