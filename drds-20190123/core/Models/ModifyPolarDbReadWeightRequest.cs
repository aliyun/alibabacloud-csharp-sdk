// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyPolarDbReadWeightRequest : TeaModel {
        /// <summary>
        /// Polar cluster ID.
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The node list in the destination apsaradb for PolarDB cluster. The nodes in each cluster are separated with commas (,) and colons (:).
        /// </summary>
        [NameInMap("DbNodeIds")]
        [Validation(Required=false)]
        public string DbNodeIds { get; set; }

        /// <summary>
        /// The ID of a DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The weight of the PolarDB cluster. Separate multiple weights with commas (,).
        /// </summary>
        [NameInMap("Weights")]
        [Validation(Required=false)]
        public string Weights { get; set; }

    }

}
