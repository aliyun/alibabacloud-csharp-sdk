// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnConditionIPBInfoResponseBody : TeaModel {
        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<DescribeCdnConditionIPBInfoResponseBodyDatas> Datas { get; set; }
        public class DescribeCdnConditionIPBInfoResponseBodyDatas : TeaModel {
            /// <summary>
            /// The configuration value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
