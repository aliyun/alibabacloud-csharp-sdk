// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20241107.Models
{
    public class GetLabelTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D5798660-1531-5D12-9C20-16FEE9D22351</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://yic-pre.oss-cn-hangzhou.aliyuncs.com/ai_tag_algo_log/1539704706413278/829593441691238400/merge_label_final_result?Expires=1732083305&OSSAccessKeyId=LTAI5tPHLyFPhh4UoRias4Zg&Signature=Am3cBxlc6hYFKtdGlw9o1R26Vsk%3D">https://yic-pre.oss-cn-hangzhou.aliyuncs.com/ai_tag_algo_log/1539704706413278/829593441691238400/merge_label_final_result?Expires=1732083305&amp;OSSAccessKeyId=LTAI5tPHLyFPhh4UoRias4Zg&amp;Signature=Am3cBxlc6hYFKtdGlw9o1R26Vsk%3D</a></para>
        /// </summary>
        [NameInMap("resultDataUrl")]
        [Validation(Required=false)]
        public string ResultDataUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20023</para>
        /// </summary>
        [NameInMap("tokens")]
        [Validation(Required=false)]
        public long? Tokens { get; set; }

    }

}
