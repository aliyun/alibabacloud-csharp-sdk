// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Message : TeaModel {
        /// <summary>
        /// <para>Assistant type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc/translate</para>
        /// </summary>
        [NameInMap("AssistantType")]
        [Validation(Required=false)]
        public string AssistantType { get; set; }

        /// <summary>
        /// <para>The content of the question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, which park is closest to me?</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The time when the message was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:10:52.83948013+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The dataset that the answer references to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The language of the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>Indicates whether the message is a regenerated answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Regenerate")]
        [Validation(Required=false)]
        public bool? Regenerate { get; set; }

        /// <summary>
        /// <para>The answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, I\&quot;m your assistant.</para>
        /// </summary>
        [NameInMap("Reply")]
        [Validation(Required=false)]
        public string Reply { get; set; }

        /// <summary>
        /// <para>Rate</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.99</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        /// <summary>
        /// <para>The URI of the source file from which the answer was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/sample.docx</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The compliance check results. Valid values: pass block</para>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// <para>The tone of the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("Tone")]
        [Validation(Required=false)]
        public string Tone { get; set; }

        /// <summary>
        /// <para>The topic in the question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The value varies based on the value of the AssistantType parameter.</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
