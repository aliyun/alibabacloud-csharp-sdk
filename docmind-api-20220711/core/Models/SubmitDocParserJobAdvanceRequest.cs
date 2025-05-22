// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitDocParserJobAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>docStructure.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileNameExtension")]
        [Validation(Required=false)]
        public string FileNameExtension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf">https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("FormulaEnhancement")]
        [Validation(Required=false)]
        public bool? FormulaEnhancement { get; set; }

        [NameInMap("LlmEnhancement")]
        [Validation(Required=false)]
        public bool? LlmEnhancement { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public string PageIndex { get; set; }

    }

}
