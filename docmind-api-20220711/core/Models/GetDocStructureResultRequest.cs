// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class GetDocStructureResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>docmind-20220816-1e89d65c</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ImageStrategy")]
        [Validation(Required=false)]
        public string ImageStrategy { get; set; }

        [NameInMap("RevealMarkdown")]
        [Validation(Required=false)]
        public bool? RevealMarkdown { get; set; }

        [NameInMap("UseUrlResponseBody")]
        [Validation(Required=false)]
        public bool? UseUrlResponseBody { get; set; }

    }

}
