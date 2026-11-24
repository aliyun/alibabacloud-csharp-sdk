// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DocumentTranslateRequest : TeaModel {
        /// <summary>
        /// <para>Supports PDF, WORD, and EXCEL formats. Use uppercase letters for the input parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PDF</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>● Specify the intervention glossary ID when the intervention feature is required.<br>● Supports custom translation results, including:<br>○ Do-not-translate (ABC-ABC).<br>○ Specified translation (ABC-DEF).<br>○ Translation omission (ABC-null).
        /// Commonly used in scenarios such as brand word protection.<br>Example value: &quot;glossary_1&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The target language.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The OSS URL path of the document to be translated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aib-innovation-oss.oss-accelerate.aliyuncs.com/AI_Business/38dao/testdemo.pdf?Expires=3356578313&OSSAccessKeyId=LTAI5tE8X3****6SRU1V8dig&Signature=8niQY2HtMQY7h****SUdyORML9E%3D">https://aib-innovation-oss.oss-accelerate.aliyuncs.com/AI_Business/38dao/testdemo.pdf?Expires=3356578313&amp;OSSAccessKeyId=LTAI5tE8X3****6SRU1V8dig&amp;Signature=8niQY2HtMQY7h****SUdyORML9E%3D</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
