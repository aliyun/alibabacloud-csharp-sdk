// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class GetDocParserResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>docmind-20220816-1e89d65c</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LayoutNum")]
        [Validation(Required=false)]
        public int? LayoutNum { get; set; }

        [NameInMap("LayoutStepSize")]
        [Validation(Required=false)]
        public int? LayoutStepSize { get; set; }

    }

}
