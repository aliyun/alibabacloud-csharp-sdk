// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableSqlConcurrencyControlRequest : TeaModel {
        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  The database instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the throttling rule that is applied to the instance. You can call the [GetRunningSqlConcurrencyControlRules](~~223538~~) operation to query the ID.
        /// </summary>
        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

    }

}
