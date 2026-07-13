// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the disaster recovery plan was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T05:04Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was created. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565499867000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The number of abnormal address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FaultAddrPoolNum")]
        [Validation(Required=false)]
        public int? FaultAddrPoolNum { get; set; }

        [NameInMap("FaultAddrPools")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlanResponseBodyFaultAddrPools FaultAddrPools { get; set; }
        public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPools : TeaModel {
            [NameInMap("FaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool> FaultAddrPool { get; set; }
            public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool : TeaModel {
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                [NameInMap("AddrPoolName")]
                [Validation(Required=false)]
                public string AddrPoolName { get; set; }

                [NameInMap("Addrs")]
                [Validation(Required=false)]
                public DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrs Addrs { get; set; }
                public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrs : TeaModel {
                    [NameInMap("Addr")]
                    [Validation(Required=false)]
                    public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrsAddr> Addr { get; set; }
                    public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrsAddr : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T05:04Z</para>
        /// </summary>
        [NameInMap("LastExecuteTime")]
        [Validation(Required=false)]
        public string LastExecuteTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last executed. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505898000</para>
        /// </summary>
        [NameInMap("LastExecuteTimestamp")]
        [Validation(Required=false)]
        public long? LastExecuteTimestamp { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last rolled back. The value is a string that represents a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505919000</para>
        /// </summary>
        [NameInMap("LastRollbackTime")]
        [Validation(Required=false)]
        public string LastRollbackTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last rolled back. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505898000</para>
        /// </summary>
        [NameInMap("LastRollbackTimestamp")]
        [Validation(Required=false)]
        public long? LastRollbackTimestamp { get; set; }

        /// <summary>
        /// <para>The name of the disaster recovery plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name-example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the disaster recovery plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10****</para>
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark-example</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A5F4315-D6E8-435E-82DF-24F4C97D6999</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the disaster recovery plan:</para>
        /// <list type="bullet">
        /// <item><description><para>UNEXECUTED: The disaster recovery plan is not executed.</para>
        /// </description></item>
        /// <item><description><para>EXECUTED: The disaster recovery plan is being executed.</para>
        /// </description></item>
        /// <item><description><para>ROLLED_BACK: The disaster recovery plan is being rolled back.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UNEXECUTED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last updated. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505898000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
