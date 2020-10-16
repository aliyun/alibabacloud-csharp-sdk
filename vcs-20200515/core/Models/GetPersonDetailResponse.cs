// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonDetailResponse : TeaModel {
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
        public GetPersonDetailResponseData Data { get; set; }
        public class GetPersonDetailResponseData : TeaModel {
            [NameInMap("PicUrl")]
            [Validation(Required=true)]
            public string PicUrl { get; set; }
            [NameInMap("PersonId")]
            [Validation(Required=true)]
            public string PersonId { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=true)]
            public List<GetPersonDetailResponseDataTagList> TagList { get; set; }
            public class GetPersonDetailResponseDataTagList : TeaModel {
                public string TagCode { get; set; }
                public string TagName { get; set; }
                public string TagValue { get; set; }
                public string TagValueId { get; set; }
            }
        };

    }

}
