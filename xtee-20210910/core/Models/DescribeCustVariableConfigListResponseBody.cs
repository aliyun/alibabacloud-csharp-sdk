// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeCustVariableConfigListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeCustVariableConfigListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeCustVariableConfigListResponseBodyResultObject : TeaModel {
            [NameInMap("configKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            [NameInMap("configValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

        }

    }

}
