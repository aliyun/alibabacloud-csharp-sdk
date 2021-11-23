// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreatePluginRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public string PluginData { get; set; }

        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePluginRequestTag> Tag { get; set; }
        public class CreatePluginRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
