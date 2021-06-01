/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210501.Models
{
    public class SearchByPicRequest : TeaModel {
        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

    }

}
