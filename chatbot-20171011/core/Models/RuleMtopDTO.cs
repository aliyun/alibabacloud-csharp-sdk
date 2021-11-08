// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class RuleMtopDTO : TeaModel {
        /// <summary>
        /// Error
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public List<string> Error { get; set; }

        /// <summary>
        /// Strict
        /// </summary>
        [NameInMap("Strict")]
        [Validation(Required=false)]
        public bool? Strict { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// Warning
        /// </summary>
        [NameInMap("Warning")]
        [Validation(Required=false)]
        public List<string> Warning { get; set; }

    }

}
