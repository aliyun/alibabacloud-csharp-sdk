// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebInstanceRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebInstanceRelations")]
        [Validation(Required=false)]
        public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelations> WebInstanceRelations { get; set; }
        public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelations : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("InstanceDetails")]
            [Validation(Required=false)]
            public List<DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribeWebInstanceRelationsResponseBodyWebInstanceRelationsInstanceDetails : TeaModel {
                [NameInMap("EipList")]
                [Validation(Required=false)]
                public List<string> EipList { get; set; }

                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
