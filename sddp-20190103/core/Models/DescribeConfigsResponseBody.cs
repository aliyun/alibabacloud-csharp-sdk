// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeConfigsResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeConfigsResponseBodyConfigList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
