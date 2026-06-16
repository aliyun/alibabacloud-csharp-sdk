// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DocumentTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The type of the document. Valid values: PDF and Word. Size limits: Word 200 MB/300 pages, PDF 200 MB/300 pages. The maximum size of a single file is 200 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PDF</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The glossary ID to use when the glossary feature is required. Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for brand name protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>glossary_1</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>The target language. The language code uses the two-letter ISO 639-1 standard.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The OSS URL of the document to be translated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aib-innovation-oss.oss-accelerate.aliyuncs.com/AI_Business/38dao/testdemo.pdf?Expires=3356578313&OSSAccessKeyId=LTAI5tE8X3gEy66SRU1V8dig&Signature=8niQY2HtMQY7h05zmSUdyORML9E%3D">https://aib-innovation-oss.oss-accelerate.aliyuncs.com/AI_Business/38dao/testdemo.pdf?Expires=3356578313&amp;OSSAccessKeyId=LTAI5tE8X3gEy66SRU1V8dig&amp;Signature=8niQY2HtMQY7h05zmSUdyORML9E%3D</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
