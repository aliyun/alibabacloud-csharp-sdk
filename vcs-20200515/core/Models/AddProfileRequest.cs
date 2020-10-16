// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddProfileRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=true)]
        public string IsvSubId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=true)]
        public long CatalogId { get; set; }

        [NameInMap("IdNumber")]
        [Validation(Required=false)]
        public string IdNumber { get; set; }

        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        [NameInMap("LiveAddress")]
        [Validation(Required=false)]
        public string LiveAddress { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public int? Gender { get; set; }

        [NameInMap("PlateNo")]
        [Validation(Required=false)]
        public string PlateNo { get; set; }

        [NameInMap("PhoneNo")]
        [Validation(Required=false)]
        public string PhoneNo { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

    }

}
