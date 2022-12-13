// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DataValue : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("configDescription")]
        [Validation(Required=false)]
        public string ConfigDescription { get; set; }

        [NameInMap("configCode")]
        [Validation(Required=false)]
        public string ConfigCode { get; set; }

        [NameInMap("parentCode")]
        [Validation(Required=false)]
        public string ParentCode { get; set; }

        [NameInMap("configKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        [NameInMap("configValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        [NameInMap("requirement")]
        [Validation(Required=false)]
        public bool? Requirement { get; set; }

    }

}
