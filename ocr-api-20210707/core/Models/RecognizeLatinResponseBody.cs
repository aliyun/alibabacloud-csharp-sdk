// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeLatinResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;angle&quot;:1,&quot;content&quot;:&quot;Đậm Phong Cách Khác Biêt  Trên tay chế tác nguyên khối dẫn đầu xu hướng với thiết kế thần máy liền mạch, độ mông ấn tượng 8.5mm cùng   kiểu dáng mặt kinh bóng mượt, sang trọng từ Galaxy M30. Vừa vặn hoền hẩo trong lông bần tay, tho thích thể hiện   phong cách thời thượng với hai phiên bản màu Đen hoặc Xanh cắ tính.  xanh Ngân Hà   Đen Ngả Khói  OC S   &quot;,&quot;height&quot;:821,&quot;orgHeight&quot;:803,&quot;orgWidth&quot;:1075,&quot;prism_version&quot;:&quot;1.0.9&quot;,&quot;prism_wnum&quot;:9,&quot;prism_wordsInfo&quot;:[{&quot;angle&quot;:0,&quot;direction&quot;:0,&quot;height&quot;:37,&quot;pos&quot;:[{&quot;x&quot;:293,&quot;y&quot;:37},{&quot;x&quot;:776,&quot;y&quot;:29},{&quot;x&quot;:777,&quot;y&quot;:66},{&quot;x&quot;:294,&quot;y&quot;:74}],&quot;prob&quot;:99,&quot;width&quot;:484,&quot;word&quot;:&quot;Đậm Phong Cách&quot;,&quot;x&quot;:292,&quot;y&quot;:24}],&quot;width&quot;:1088}</para>
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
