// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class QueryEniQosGroupByInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEniQosGroupByInstanceResponseBodyData Data { get; set; }
        public class QueryEniQosGroupByInstanceResponseBodyData : TeaModel {
            [NameInMap("EniQosGroups")]
            [Validation(Required=false)]
            public List<string> EniQosGroups { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
