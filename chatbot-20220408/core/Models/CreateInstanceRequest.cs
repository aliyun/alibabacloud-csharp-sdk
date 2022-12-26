// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

    }

}
