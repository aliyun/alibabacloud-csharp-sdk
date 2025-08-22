// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ValidateModuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2daf4227f747cbf11a5501f18cc5e004</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;main.tf&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("codeMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> CodeMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Upload</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("sourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

    }

}
