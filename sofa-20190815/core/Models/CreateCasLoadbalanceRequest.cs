// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateCasLoadbalanceRequest : TeaModel {
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public string AppServiceId { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ShareMode")]
        [Validation(Required=false)]
        public bool? ShareMode { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("ListenersRepeatList")]
        [Validation(Required=false)]
        public List<string> ListenersRepeatList { get; set; }

    }

}
