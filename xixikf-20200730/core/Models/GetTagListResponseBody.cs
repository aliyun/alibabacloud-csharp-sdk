// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetTagListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetTagListResponseBodyData> Data { get; set; }
        public class GetTagListResponseBodyData : TeaModel {
            [NameInMap("ScenarioCode")]
            [Validation(Required=false)]
            public string ScenarioCode { get; set; }

            [NameInMap("TagGroupCode")]
            [Validation(Required=false)]
            public string TagGroupCode { get; set; }

            [NameInMap("TagGroupName")]
            [Validation(Required=false)]
            public string TagGroupName { get; set; }

            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<GetTagListResponseBodyDataTagValues> TagValues { get; set; }
            public class GetTagListResponseBodyDataTagValues : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EntityRelationNumber")]
                [Validation(Required=false)]
                public string EntityRelationNumber { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("TagGroupCode")]
                [Validation(Required=false)]
                public string TagGroupCode { get; set; }

                [NameInMap("TagGroupName")]
                [Validation(Required=false)]
                public string TagGroupName { get; set; }

                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
