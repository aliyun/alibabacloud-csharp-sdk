// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class ModifyRdsReadWeightRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceNames")]
        [Validation(Required=false)]
        public string InstanceNames { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Weights")]
        [Validation(Required=false)]
        public string Weights { get; set; }

    }

}
