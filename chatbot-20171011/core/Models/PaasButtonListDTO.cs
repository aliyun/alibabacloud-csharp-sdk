// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasButtonListDTO : TeaModel {
        /// <summary>
        /// Button
        /// </summary>
        [NameInMap("Button")]
        [Validation(Required=false)]
        public List<PaasButtonDTO> Button { get; set; }

        /// <summary>
        /// Intro
        /// </summary>
        [NameInMap("Intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

    }

}
