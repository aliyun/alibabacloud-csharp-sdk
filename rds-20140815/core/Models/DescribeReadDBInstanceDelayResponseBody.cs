// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReadDBInstanceDelayResponseBody : TeaModel {
        /// <summary>
        /// The primary instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The latency of data replication. Unit: seconds.
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// The latency information.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeReadDBInstanceDelayResponseBodyItems Items { get; set; }
        public class DescribeReadDBInstanceDelayResponseBodyItems : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeReadDBInstanceDelayResponseBodyItemsItems> Items { get; set; }
            public class DescribeReadDBInstanceDelayResponseBodyItemsItems : TeaModel {
                /// <summary>
                /// The primary instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// An array that consists of information about the read-only instance.
                /// </summary>
                [NameInMap("ReadDBInstanceNames")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames ReadDBInstanceNames { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDBInstanceNames : TeaModel {
                    [NameInMap("ReadDBInstanceName")]
                    [Validation(Required=false)]
                    public List<string> ReadDBInstanceName { get; set; }

                }

                /// <summary>
                /// The latency of data replication.
                /// </summary>
                [NameInMap("ReadDelayTimes")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes ReadDelayTimes { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadDelayTimes : TeaModel {
                    [NameInMap("ReadDelayTime")]
                    [Validation(Required=false)]
                    public List<string> ReadDelayTime { get; set; }

                }

                /// <summary>
                /// The information about the write-ahead log (WAL) latency.
                /// 
                /// >  This parameter is returned only when the primary instance runs PostgreSQL.
                /// </summary>
                [NameInMap("ReadonlyInstanceDelay")]
                [Validation(Required=false)]
                public DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay ReadonlyInstanceDelay { get; set; }
                public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelay : TeaModel {
                    [NameInMap("ReadonlyInstanceDelay")]
                    [Validation(Required=false)]
                    public List<DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay> ReadonlyInstanceDelay { get; set; }
                    public class DescribeReadDBInstanceDelayResponseBodyItemsItemsReadonlyInstanceDelayReadonlyInstanceDelay : TeaModel {
                        /// <summary>
                        /// The duration that is allowed for the latency in the persistence of WAL data. Unit: seconds.
                        /// </summary>
                        [NameInMap("FlushLag")]
                        [Validation(Required=false)]
                        public string FlushLag { get; set; }

                        /// <summary>
                        /// The data size that is allowed for the latency in the persistence of WAL data. Unit: MB.
                        /// </summary>
                        [NameInMap("FlushLatency")]
                        [Validation(Required=false)]
                        public string FlushLatency { get; set; }

                        /// <summary>
                        /// The read-only instance ID.
                        /// </summary>
                        [NameInMap("ReadDBInstanceName")]
                        [Validation(Required=false)]
                        public string ReadDBInstanceName { get; set; }

                        /// <summary>
                        /// The duration that is allowed for the latency in the playback of WAL data. Unit: seconds.
                        /// </summary>
                        [NameInMap("ReplayLag")]
                        [Validation(Required=false)]
                        public string ReplayLag { get; set; }

                        /// <summary>
                        /// The data size that is allowed for the latency in the playback of WAL data. Unit: MB.
                        /// </summary>
                        [NameInMap("ReplayLatency")]
                        [Validation(Required=false)]
                        public string ReplayLatency { get; set; }

                        /// <summary>
                        /// The data size that is allowed for the latency in the sending of WAL data. Unit: MB.
                        /// </summary>
                        [NameInMap("SendLatency")]
                        [Validation(Required=false)]
                        public string SendLatency { get; set; }

                        /// <summary>
                        /// The duration that is allowed for the latency in the write-back of WAL data. Unit: seconds.
                        /// </summary>
                        [NameInMap("WriteLag")]
                        [Validation(Required=false)]
                        public string WriteLag { get; set; }

                        /// <summary>
                        /// The data size that is allowed for the latency in the write-back of WAL data. Unit: MB.
                        /// </summary>
                        [NameInMap("WriteLatency")]
                        [Validation(Required=false)]
                        public string WriteLatency { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The read-only instance ID.
        /// </summary>
        [NameInMap("ReadDBInstanceId")]
        [Validation(Required=false)]
        public string ReadDBInstanceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
