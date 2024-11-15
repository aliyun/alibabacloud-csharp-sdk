// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeKoreanResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;위 기자재는 [전파법] 제58조의2 제3항에 따라 등록되었음을 증명합니다.  Itis verified thatforegoing equipment has bee en registered underthe Clause 3, Article 58-2 of Radio Waves Act.  y0 13년(Year)_08월(Month) 16일(Date) 국립전 파연구 국립전파연7 구원장 인 Dlrector General ofNatlonal Radio Research Agency    적합등록 방송통신기자재는 반드시\&quot;적합성평가표: .시\&quot;를 부착하여 유통하여야 합니다.  위반시 과태료 처분 및등록이 취소될 수 있습니다.  &quot;,&quot;height&quot;:499,&quot;orgHeight&quot;:499,&quot;orgWidth&quot;:1153,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:19,&quot;prism_wordsInfo&quot;:[{&quot;angle&quot;:-90,&quot;direction&quot;:0,&quot;height&quot;:587,&quot;pos&quot;:[{&quot;x&quot;:61,&quot;y&quot;:18},{&quot;x&quot;:647,&quot;y&quot;:16},{&quot;x&quot;:647,&quot;y&quot;:43},{&quot;x&quot;:61,&quot;y&quot;:45}],&quot;prob&quot;:98,&quot;width&quot;:27,&quot;word&quot;:&quot;위 기자재는 [전파법] 제58조의2 제3항에 따라&quot;,&quot;x&quot;:341,&quot;y&quot;:-263}],&quot;width&quot;:1153}</para>
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
