/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class AddImageRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

    }

}
