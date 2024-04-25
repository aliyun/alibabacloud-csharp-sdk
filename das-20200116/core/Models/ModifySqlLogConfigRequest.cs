// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigRequest : TeaModel {
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ModifySqlLogConfigRequestFilters> Filters { get; set; }
        public class ModifySqlLogConfigRequestFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("HotRetention")]
        [Validation(Required=false)]
        public int? HotRetention { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestEnable")]
        [Validation(Required=false)]
        public bool? RequestEnable { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
