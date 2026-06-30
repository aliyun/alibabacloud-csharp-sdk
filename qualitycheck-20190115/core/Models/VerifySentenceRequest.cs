// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class VerifySentenceRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Full JSON string. For details, see the following table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;taskId&quot;:&quot;EA701F66-8CA2-4A79-8E3C-A6F2F****&quot;,&quot;fileName&quot;:&quot;人工校验测试-订购茶叶.wav&quot;,&quot;dialogueId&quot;:1,&quot;roleCorrect&quot;:false,&quot;sourceRole&quot;:0,&quot;textCorrect&quot;:false,&quot;sourceText&quot;:&quot;我要订购大量的信阳毛尖。&quot;,&quot;oldIncorrectWords&quot;:3,&quot;targetText&quot;:&quot;我要订购大大的南阳毛巾。&quot;,&quot;targetRole&quot;:1}&quot;</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
