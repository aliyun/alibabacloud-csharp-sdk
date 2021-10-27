// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsDrdsDBResponseBody : TeaModel {
        [NameInMap("RdsDrdsDbs")]
        [Validation(Required=false)]
        public DescribeRdsDrdsDBResponseBodyRdsDrdsDbs RdsDrdsDbs { get; set; }
        public class DescribeRdsDrdsDBResponseBodyRdsDrdsDbs : TeaModel {
            [NameInMap("RdsDrdsDb")]
            [Validation(Required=false)]
            public List<DescribeRdsDrdsDBResponseBodyRdsDrdsDbsRdsDrdsDb> RdsDrdsDb { get; set; }
            public class DescribeRdsDrdsDBResponseBodyRdsDrdsDbsRdsDrdsDb : TeaModel {
                public DescribeRdsDrdsDBResponseBodyRdsDrdsDbsRdsDrdsDbDBList DBList { get; set; }
                public class DescribeRdsDrdsDBResponseBodyRdsDrdsDbsRdsDrdsDbDBList : TeaModel {
                    [NameInMap("DB")]
                    [Validation(Required=false)]
                    public List<string> DB { get; set; }

                }
                public string RdsId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
