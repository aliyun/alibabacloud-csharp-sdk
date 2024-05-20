// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateConfigMapRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigMapId")]
        [Validation(Required=false)]
        public long? ConfigMapId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
