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

        /// <summary>
        /// <para>The latency information.</para>
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
                /// <para>The primary instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp*****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>An array that consists of information about the read-only instance.</para>
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
                /// <para>The latency of data replication.</para>
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
                /// <para>The information about the write-ahead log (WAL) latency.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the primary instance runs PostgreSQL.</para>
                /// </remarks>
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
                        /// <para>The duration that is allowed for the latency in the persistence of WAL data. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("FlushLag")]
                        [Validation(Required=false)]
                        public string FlushLag { get; set; }

                        /// <summary>
                        /// <para>The data size that is allowed for the latency in the persistence of WAL data. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("FlushLatency")]
                        [Validation(Required=false)]
                        public string FlushLatency { get; set; }

                        /// <summary>
                        /// <para>The read-only instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rr-bp*****</para>
                        /// </summary>
                        [NameInMap("ReadDBInstanceName")]
                        [Validation(Required=false)]
                        public string ReadDBInstanceName { get; set; }

                        /// <summary>
                        /// <para>The duration that is allowed for the latency in the playback of WAL data. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ReplayLag")]
                        [Validation(Required=false)]
                        public string ReplayLag { get; set; }

                        /// <summary>
                        /// <para>The data size that is allowed for the latency in the playback of WAL data. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ReplayLatency")]
                        [Validation(Required=false)]
                        public string ReplayLatency { get; set; }

                        /// <summary>
                        /// <para>The data size that is allowed for the latency in the sending of WAL data. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SendLatency")]
                        [Validation(Required=false)]
                        public string SendLatency { get; set; }

                        /// <summary>
                        /// <para>The duration that is allowed for the latency in the write-back of WAL data. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("WriteLag")]
                        [Validation(Required=false)]
                        public string WriteLag { get; set; }

                        /// <summary>
                        /// <para>The data size that is allowed for the latency in the write-back of WAL data. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
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
