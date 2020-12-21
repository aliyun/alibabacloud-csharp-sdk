// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPersonDetailResponseBodyData Data { get; set; }
        public class GetPersonDetailResponseBodyData : TeaModel {
            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<GetPersonDetailResponseBodyDataTagList> TagList { get; set; }
            public class GetPersonDetailResponseBodyDataTagList : TeaModel {
                public string TagValueId { get; set; }
                public string TagName { get; set; }
                public string TagCode { get; set; }
                public string TagValue { get; set; }
            }
            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
