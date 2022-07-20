// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeQueryConfigsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeQueryConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeQueryConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
