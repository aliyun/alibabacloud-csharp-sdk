// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVulGlobalConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VulGlobalConfigList")]
        [Validation(Required=false)]
        public List<ListVulGlobalConfigResponseBodyVulGlobalConfigList> VulGlobalConfigList { get; set; }
        public class ListVulGlobalConfigResponseBodyVulGlobalConfigList : TeaModel {
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

        }

    }

}
