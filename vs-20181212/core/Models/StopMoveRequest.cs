// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StopMoveRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Pan")]
        [Validation(Required=false)]
        public bool? Pan { get; set; }

        [NameInMap("Tilt")]
        [Validation(Required=false)]
        public bool? Tilt { get; set; }

        [NameInMap("Zoom")]
        [Validation(Required=false)]
        public bool? Zoom { get; set; }

    }

}
