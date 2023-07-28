// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnConditionIPBInfoResponseBody : TeaModel {
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<DescribeCdnConditionIPBInfoResponseBodyDatas> Datas { get; set; }
        public class DescribeCdnConditionIPBInfoResponseBodyDatas : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
