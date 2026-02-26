// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReadDBInstanceDelayResponseBody : TeaModel {
        /// <summary>
        /// <para>The primary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The latency of data replication. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
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
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("ReadDBInstanceNames")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames ReadDBInstanceNames { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames : TeaModel {
                    [NameInMap("ReadDBInstanceName")]
                    [Validation(Required=false)]
                    public List<string> ReadDBInstanceName { get; set; }

                }

                [NameInMap("ReadDelayTimes")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes ReadDelayTimes { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes : TeaModel {
                    [NameInMap("ReadDelayTime")]
                    [Validation(Required=false)]
                    public List<string> ReadDelayTime { get; set; }

                }

                [NameInMap("ReadonlyInstanceDelay")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay ReadonlyInstanceDelay { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay : TeaModel {
                    [NameInMap("ReadonlyInstanceDelay")]
                    [Validation(Required=false)]
                    public List<DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay> ReadonlyInstanceDelay { get; set; }
                    public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay : TeaModel {
                        [NameInMap("FlushLag")]
                        [Validation(Required=false)]
                        public string FlushLag { get; set; }

                        [NameInMap("FlushLatency")]
                        [Validation(Required=false)]
                        public string FlushLatency { get; set; }

                        [NameInMap("ReadDBInstanceName")]
                        [Validation(Required=false)]
                        public string ReadDBInstanceName { get; set; }

                        [NameInMap("ReplayLag")]
                        [Validation(Required=false)]
                        public string ReplayLag { get; set; }

                        [NameInMap("ReplayLatency")]
                        [Validation(Required=false)]
                        public string ReplayLatency { get; set; }

                        [NameInMap("SendLatency")]
                        [Validation(Required=false)]
                        public string SendLatency { get; set; }

                        [NameInMap("WriteLag")]
                        [Validation(Required=false)]
                        public string WriteLag { get; set; }

                        [NameInMap("WriteLatency")]
                        [Validation(Required=false)]
                        public string WriteLatency { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The read-only instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rr-bp*****</para>
        /// </summary>
        [NameInMap("ReadDBInstanceId")]
        [Validation(Required=false)]
        public string ReadDBInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1BDDEA8-452D-450B-AB10-CD5C5BAFC5DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
