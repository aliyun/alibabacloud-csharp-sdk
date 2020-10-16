// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddProfileResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public AddProfileResponseData Data { get; set; }
        public class AddProfileResponseData : TeaModel {
            [NameInMap("LiveAddress")]
            [Validation(Required=true)]
            public string LiveAddress { get; set; }
            [NameInMap("SceneType")]
            [Validation(Required=true)]
            public string SceneType { get; set; }
            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }
            [NameInMap("FaceUrl")]
            [Validation(Required=true)]
            public string FaceUrl { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=true)]
            public string Gender { get; set; }
            [NameInMap("IdNumber")]
            [Validation(Required=true)]
            public string IdNumber { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }
            [NameInMap("PhoneNo")]
            [Validation(Required=true)]
            public string PhoneNo { get; set; }
            [NameInMap("PlateNo")]
            [Validation(Required=true)]
            public string PlateNo { get; set; }
            [NameInMap("CatalogId")]
            [Validation(Required=true)]
            public int? CatalogId { get; set; }
            [NameInMap("ProfileId")]
            [Validation(Required=true)]
            public int? ProfileId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
        };

    }

}
