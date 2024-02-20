// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class GenerateTextDeformationRequest : TeaModel {
        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("FontName")]
        [Validation(Required=false)]
        public string FontName { get; set; }

        [NameInMap("N")]
        [Validation(Required=false)]
        public long? N { get; set; }

        [NameInMap("OutputImageRatio")]
        [Validation(Required=false)]
        public string OutputImageRatio { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("TextContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        [NameInMap("TtfUrl")]
        [Validation(Required=false)]
        public string TtfUrl { get; set; }

    }

}
