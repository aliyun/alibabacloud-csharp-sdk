// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// The time when the disaster recovery plan was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The number of faulty address pools.
        /// </summary>
        [NameInMap("FaultAddrPoolNum")]
        [Validation(Required=false)]
        public int? FaultAddrPoolNum { get; set; }

        /// <summary>
        /// The list of faulty address pools.
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
                /// The ID of the address pool.
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// The name of the address pool.
                /// </summary>
                [NameInMap("AddrPoolName")]
                [Validation(Required=false)]
                public string AddrPoolName { get; set; }

                /// <summary>
                /// The list of addresses in the address pool.
                /// </summary>
                [NameInMap("Addrs")]
                [Validation(Required=false)]
                public DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrs Addrs { get; set; }
                public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrs : TeaModel {
                    [NameInMap("Addr")]
                    [Validation(Required=false)]
                    public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrsAddr> Addr { get; set; }
                    public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddrsAddr : TeaModel {
                        /// <summary>
                        /// The ID of the address.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// The address work mode. It is the mode that was set for the IP address to work.
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// The address value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the GTM instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// The last time when the recovery plan was executed.
        /// </summary>
        [NameInMap("LastExecuteTime")]
        [Validation(Required=false)]
        public string LastExecuteTime { get; set; }

        /// <summary>
        /// A timestamp that indicates the last time when the recovery plan was executed.
        /// </summary>
        [NameInMap("LastExecuteTimestamp")]
        [Validation(Required=false)]
        public long? LastExecuteTimestamp { get; set; }

        /// <summary>
        /// The last time when the disaster recovery plan was rolled back.
        /// </summary>
        [NameInMap("LastRollbackTime")]
        [Validation(Required=false)]
        public string LastRollbackTime { get; set; }

        /// <summary>
        /// A timestamp that indicates the last time when the disaster recovery plan was rolled back.
        /// </summary>
        [NameInMap("LastRollbackTimestamp")]
        [Validation(Required=false)]
        public long? LastRollbackTimestamp { get; set; }

        /// <summary>
        /// The name of the disaster recovery plan queried.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the disaster recovery plan queried.
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

        /// <summary>
        /// The remarks on the disaster recovery plan.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the disaster recovery plan queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The last time when the disaster recovery plan was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// A timestamp that indicates the last time when the disaster recovery plan was updated.
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
