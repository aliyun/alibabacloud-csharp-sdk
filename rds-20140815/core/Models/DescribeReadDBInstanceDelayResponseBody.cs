// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReadDBInstanceDelayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ReadDBInstanceId")]
        [Validation(Required=false)]
        public string ReadDBInstanceId { get; set; }

        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeReadDBInstanceDelayResponseBodyItems Items { get; set; }
        public class DescribeReadDBInstanceDelayResponseBodyItems : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeReadDBInstanceDelayResponseBodyItemsItems> Items { get; set; }
            public class DescribeReadDBInstanceDelayResponseBodyItemsItems : TeaModel {
                public string DBInstanceId { get; set; }
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames ReadDBInstanceNames { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames : TeaModel {
                    [NameInMap("ReadDBInstanceName")]
                    [Validation(Required=false)]
                    public List<string> ReadDBInstanceName { get; set; }

                }
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes ReadDelayTimes { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes : TeaModel {
                    [NameInMap("ReadDelayTime")]
                    [Validation(Required=false)]
                    public List<string> ReadDelayTime { get; set; }

                }
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay ReadonlyInstanceDelay { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay : TeaModel {
                    [NameInMap("ReadonlyInstanceDelay")]
                    [Validation(Required=false)]
                    public List<DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay> ReadonlyInstanceDelay { get; set; }
                    public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay : TeaModel {
                        [NameInMap("ReplayLatency")]
                        [Validation(Required=false)]
                        public string ReplayLatency { get; set; }

                        [NameInMap("FlushLag")]
                        [Validation(Required=false)]
                        public string FlushLag { get; set; }

                        [NameInMap("FlushLatency")]
                        [Validation(Required=false)]
                        public string FlushLatency { get; set; }

                        [NameInMap("SendLatency")]
                        [Validation(Required=false)]
                        public string SendLatency { get; set; }

                        [NameInMap("WriteLag")]
                        [Validation(Required=false)]
                        public string WriteLag { get; set; }

                        [NameInMap("ReplayLag")]
                        [Validation(Required=false)]
                        public string ReplayLag { get; set; }

                        [NameInMap("WriteLatency")]
                        [Validation(Required=false)]
                        public string WriteLatency { get; set; }

                        [NameInMap("ReadDBInstanceName")]
                        [Validation(Required=false)]
                        public string ReadDBInstanceName { get; set; }

                    }

                }
            }
        };

    }

}
