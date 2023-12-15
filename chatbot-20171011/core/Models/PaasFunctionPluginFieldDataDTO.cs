// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasFunctionPluginFieldDataDTO : TeaModel {
        [NameInMap("AliyunFunction")]
        [Validation(Required=false)]
        public string AliyunFunction { get; set; }

        [NameInMap("AliyunService")]
        [Validation(Required=false)]
        public string AliyunService { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndPoint")]
        [Validation(Required=false)]
        public string EndPoint { get; set; }

        [NameInMap("Function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        [NameInMap("Switch")]
        [Validation(Required=false)]
        public List<PaasSwitchCaseDTO> Switch { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
