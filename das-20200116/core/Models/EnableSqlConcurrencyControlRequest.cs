// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class EnableSqlConcurrencyControlRequest : TeaModel {
        /// <summary>
        /// The duration within which the SQL throttling rule takes effect. Unit: seconds.
        /// 
        /// >  The throttling rule takes effect only within this duration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConcurrencyControlTime")]
        [Validation(Required=false)]
        public long? ConcurrencyControlTime { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  You must specify the instance ID only if your database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum number of concurrent SQL statements. Set this parameter to a positive integer.
        /// 
        /// >  When the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// The keywords that are used to identify the SQL statements that need to be throttled.
        /// 
        /// >  If you specify multiple SQL keywords, separate them with tildes (~). If the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlKeywords")]
        [Validation(Required=false)]
        public string SqlKeywords { get; set; }

        /// <summary>
        /// The type of the SQL statements. Valid values:
        /// 
        /// *   **SELECT**
        /// *   **UPDATE**
        /// *   **DELETE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

    }

}
