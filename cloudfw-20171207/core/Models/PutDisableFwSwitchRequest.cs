// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutDisableFwSwitchRequest : TeaModel {
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
