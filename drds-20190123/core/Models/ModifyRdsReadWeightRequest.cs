// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyRdsReadWeightRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The names of the ApsaraDB RDS for MySQL instances. Separate the names with commas (,).
        /// </summary>
        [NameInMap("InstanceNames")]
        [Validation(Required=false)]
        public string InstanceNames { get; set; }

        /// <summary>
        /// The weights of the ApsaraDB RDS for MySQL instances. Separate the weights with commas (,).
        /// </summary>
        [NameInMap("Weights")]
        [Validation(Required=false)]
        public string Weights { get; set; }

    }

}
