// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        [NameInMap("Division")]
        [Validation(Required=false)]
        public string Division { get; set; }

        [NameInMap("FEExtend")]
        [Validation(Required=false)]
        public string FEExtend { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

    }

}
