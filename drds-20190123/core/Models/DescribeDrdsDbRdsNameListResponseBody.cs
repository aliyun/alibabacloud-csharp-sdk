// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbRdsNameListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceNameList")]
        [Validation(Required=false)]
        public DescribeDrdsDbRdsNameListResponseBodyInstanceNameList InstanceNameList { get; set; }
        public class DescribeDrdsDbRdsNameListResponseBodyInstanceNameList : TeaModel {
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public List<string> InstanceName { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
