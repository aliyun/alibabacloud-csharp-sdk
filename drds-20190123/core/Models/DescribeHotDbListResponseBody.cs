// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeHotDbListResponseBody : TeaModel {
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotDbListResponseBodyData Data { get; set; }
        public class DescribeHotDbListResponseBodyData : TeaModel {
            [NameInMap("RandomCode")]
            [Validation(Required=false)]
            public string RandomCode { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeHotDbListResponseBodyDataList List { get; set; }
            public class DescribeHotDbListResponseBodyDataList : TeaModel {
                [NameInMap("InstanceDb")]
                [Validation(Required=false)]
                public List<DescribeHotDbListResponseBodyDataListInstanceDb> InstanceDb { get; set; }
                public class DescribeHotDbListResponseBodyDataListInstanceDb : TeaModel {
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("HotDbList")]
                    [Validation(Required=false)]
                    public DescribeHotDbListResponseBodyDataListInstanceDbHotDbList HotDbList { get; set; }
                    public class DescribeHotDbListResponseBodyDataListInstanceDbHotDbList : TeaModel {
                        [NameInMap("data")]
                        [Validation(Required=false)]
                        public List<string> Data { get; set; }
                    };

                }

            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
