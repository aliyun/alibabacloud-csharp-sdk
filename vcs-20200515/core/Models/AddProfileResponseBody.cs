// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddProfileResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddProfileResponseBodyData Data { get; set; }
        public class AddProfileResponseBodyData : TeaModel {
            [NameInMap("CatalogId")]
            [Validation(Required=false)]
            public int? CatalogId { get; set; }
            [NameInMap("ProfileId")]
            [Validation(Required=false)]
            public int? ProfileId { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public string IdNumber { get; set; }
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }
            [NameInMap("PhoneNo")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }
            [NameInMap("FaceUrl")]
            [Validation(Required=false)]
            public string FaceUrl { get; set; }
            [NameInMap("LiveAddress")]
            [Validation(Required=false)]
            public string LiveAddress { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PlateNo")]
            [Validation(Required=false)]
            public string PlateNo { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
