// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeRussianResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;Тэбако (коробочка для косметики) с рисунком в виде колес повозки&quot;,&quot;height&quot;:199,&quot;orgHeight&quot;:199,&quot;orgWidth&quot;:766,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:6,&quot;prism_wordsInfo&quot;:[{&quot;angle&quot;:-89,&quot;direction&quot;:0,&quot;height&quot;:722,&quot;pos&quot;:[{&quot;x&quot;:6,&quot;y&quot;:23},{&quot;x&quot;:728,&quot;y&quot;:26},{&quot;x&quot;:727,&quot;y&quot;:43},{&quot;x&quot;:5,&quot;y&quot;:41}],&quot;prob&quot;:99,&quot;width&quot;:17,&quot;word&quot;:&quot;Тэбако (коробочка для косметики) с рисунком в виде колес повозки， покрытая&quot;,&quot;x&quot;:358,&quot;y&quot;:-327}],&quot;width&quot;:766}</para>
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
