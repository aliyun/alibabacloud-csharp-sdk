// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasNodeDTO : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public PaasPluginDataDTO PluginData { get; set; }

        [NameInMap("Xx")]
        [Validation(Required=false)]
        public double? Xx { get; set; }

        [NameInMap("Yy")]
        [Validation(Required=false)]
        public double? Yy { get; set; }

    }

}
