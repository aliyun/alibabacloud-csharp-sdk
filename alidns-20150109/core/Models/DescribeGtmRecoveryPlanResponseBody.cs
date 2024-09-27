// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the disaster recovery plan was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T05:04Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565499867000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The number of faulty address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FaultAddrPoolNum")]
        [Validation(Required=false)]
        public int? FaultAddrPoolNum { get; set; }

        /// <summary>
        /// <para>The faulty address pools.</para>
        /// </summary>
        [NameInMap("FaultAddrPools")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlanResponseBodyFaultAddrPools FaultAddrPools { get; set; }
        public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPools : TeaModel {
            [NameInMap("FaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool> FaultAddrPool { get; set; }
            public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool : TeaModel {
                /// <summary>
                /// <para>The address pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hra0oq</para>
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// <para>The address pool name.</para>
                /// </summary>
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
                        /// <summary>
                        /// <para>The address ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>739</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The address mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OFFLINE</para>
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.1.1.1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance-zwy-38</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last executed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T05:04Z</para>
        /// </summary>
        [NameInMap("LastExecuteTime")]
        [Validation(Required=false)]
        public string LastExecuteTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505898000</para>
        /// </summary>
        [NameInMap("LastExecuteTimestamp")]
        [Validation(Required=false)]
        public long? LastExecuteTimestamp { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last rolled back. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T06:45Z</para>
        /// </summary>
        [NameInMap("LastRollbackTime")]
        [Validation(Required=false)]
        public string LastRollbackTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last rolled back. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565505919000</para>
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
        /// <para>55</para>
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

        /// <summary>
        /// <para>The description of the disaster recovery plan.</para>
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
        /// <para>The status of the disaster recovery plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNEXECUTED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-11T06:45Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the disaster recovery plan was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565499867000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
