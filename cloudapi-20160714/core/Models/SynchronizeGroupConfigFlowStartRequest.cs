// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SynchronizeGroupConfigFlowStartRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("ModifyPolicy")]
        [Validation(Required=false)]
        public string ModifyPolicy { get; set; }

        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

        [NameInMap("VpcSchema")]
        [Validation(Required=false)]
        public string VpcSchema { get; set; }

        [NameInMap("Include")]
        [Validation(Required=false)]
        public List<string> Include { get; set; }

        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public List<string> Exclude { get; set; }

    }

}
