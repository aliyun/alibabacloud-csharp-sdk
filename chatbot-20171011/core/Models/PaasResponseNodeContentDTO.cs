// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasResponseNodeContentDTO : TeaModel {
        /// <summary>
        /// ButtonList
        /// </summary>
        [NameInMap("ButtonList")]
        [Validation(Required=false)]
        public PaasButtonListDTO ButtonList { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
