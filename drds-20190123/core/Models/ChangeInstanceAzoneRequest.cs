// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ChangeInstanceAzoneRequest : TeaModel {
        [NameInMap("ChangeVSwitch")]
        [Validation(Required=false)]
        public bool? ChangeVSwitch { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("DrdsRegionId")]
        [Validation(Required=false)]
        public string DrdsRegionId { get; set; }

        [NameInMap("NewVSwitch")]
        [Validation(Required=false)]
        public string NewVSwitch { get; set; }

        /// <summary>
        /// The source zone of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("OriginAzoneId")]
        [Validation(Required=false)]
        public string OriginAzoneId { get; set; }

        /// <summary>
        /// The destination zone to which you want to modify
        /// </summary>
        [NameInMap("TargetAzoneId")]
        [Validation(Required=false)]
        public string TargetAzoneId { get; set; }

    }

}
