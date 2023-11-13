// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the operation log.
        /// </summary>
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// The operation object.
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// The type of the operation object. Valid values:
            /// 
            /// *   **1**: the IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance
            /// *   **2**: Anti-DDoS plans
            /// *   **3**: ECS instances
            /// *   **4**: all logs
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// The time when the operation was performed. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to call the API operation.
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// The type of the operation. Valid values:
            /// 
            /// *   **1**: configuring burstable protection bandwidth.
            /// *   **5**: using Anti-DDoS plans.
            /// *   **8**: changing IP addresses of ECS instances.
            /// *   **9**: deactivating blackhole filtering.
            /// *   **10**: configuring the Diversion from Origin Server policy.
            /// *   **11**: clearing all logs.
            /// *   **12**: downgrading the specifications of instances. If the instance expires or the account has overdue payments, this operation is performed to downgrade the burstable protection bandwidth.
            /// *   **13**: restoring the specifications of instances. If the instance is renewed or you have paid the overdue payments within your account, this operation is performed to restore the burstable protection bandwidth.
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// The details of the operation. This parameter is a JSON string. The string contains the following fields:
            /// 
            /// *   **newEntity**: the values of the parameters after the operation. This field must be of the STRING type.
            /// *   **oldEntity**: the values of the parameters before the operation. This field must be of the STRING type.
            /// 
            /// Both **newEntity** and **oldEntity** are JSON strings. The returned parameters vary with **OpAtion**.
            /// 
            /// If **OpAction** is **1**, **12**, or **13**, the following parameter is returned:
            /// 
            /// *   **elasticBandwidth**: the burstable protection bandwidth. The value is of the INTEGER type.
            /// 
            ///     For example: `{"newEntity":{"elasticBandwidth":300},"oldEntity":{"elasticBandwidth":300}}`
            /// 
            /// If **OpAction** is **5**, the following parameters are returned:
            /// 
            /// *   **bandwidth**: the burstable protection bandwidth. The value is of the INTEGER type. Unit: Gbit/s.
            /// 
            /// *   **count**: the number of Anti-DDoS plans. The value is of the INTEGER type.
            /// 
            /// *   **deductCount**: the number of used Anti-DDoS plans. The value is of the INTEGER type.
            /// 
            /// *   **expireTime**: the expiration time of the Anti-DDoS plans. The value is of the LONG type. The value is a UNIX timestamp. Unit: milliseconds.
            /// 
            /// *   **instanceId**: the ID of the instance. The value is of the STRING type.
            /// 
            /// *   **peakFlow**: the peak throughput on the instance. The value is of the INTEGER type. Unit: bit/s.
            /// 
            ///     For example: `{"newEntity":{"bandwidth":100,"count":4,"deductCount":1,"expireTime":1616299196000,"instanceId":"ddoscoo-cn-v641kpmq****","peakFlow":751427000}}`
            /// 
            /// If **OpAction** is **8**, the following parameter is returned:
            /// 
            /// *   **instanceId**: the ID of the ECS instance whose IP address is changed. The value is of the STRING type.
            /// 
            ///     For example: `{"newEntity":{"instanceId":"i-wz9h6nc313zptbqn****"}}`
            /// 
            /// If **OpAction** is **9**, the following parameter is returned:
            /// 
            /// *   **actionMethod**: the operation method. The value is of the STRING type. Valid value: **undo**, which indicates that you deactivated blackhole filtering.
            /// 
            ///     For example: `{"newEntity":{"actionMethod":"undo"}}`
            /// 
            /// If **OpAction** is **10**, the following parameters are returned:
            /// 
            /// *   **actionMethod**: the operation method. The value is of the STRING type. Valid values:
            /// 
            ///     *   **do**: The Diversion from Origin Server policy is enabled.
            ///     *   **undo**: The Diversion from Origin Server policy is disabled.
            /// 
            /// *   **lines**: The Internet service provider (ISP) line from which the traffic is blocked. Valid values:
            /// 
            ///     *   **ct**: China Telecom (International)
            ///     *   **cut**: China Unicom (International)
            /// 
            ///     For example: `{"newEntity":{"actionMethod":"undo","lines":["ct"]}}`
            /// 
            /// If **OpAction** is **11**, no parameter is returned, and the description is empty.
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned operation records.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
