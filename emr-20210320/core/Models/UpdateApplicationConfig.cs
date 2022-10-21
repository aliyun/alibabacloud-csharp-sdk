// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateApplicationConfig : TeaModel {
        [NameInMap("ConfigAction")]
        [Validation(Required=false)]
        public string ConfigAction { get; set; }

        [NameInMap("ConfigDescription")]
        [Validation(Required=false)]
        public string ConfigDescription { get; set; }

        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        [NameInMap("ConfigItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        [NameInMap("ConfigItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        [NameInMap("EffectiveActions")]
        [Validation(Required=false)]
        public string EffectiveActions { get; set; }

        [NameInMap("EffectiveType")]
        [Validation(Required=false)]
        public string EffectiveType { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
