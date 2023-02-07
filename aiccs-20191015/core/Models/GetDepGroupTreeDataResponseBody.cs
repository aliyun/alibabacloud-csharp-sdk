// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetDepGroupTreeDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDepGroupTreeDataResponseBodyData> Data { get; set; }
        public class GetDepGroupTreeDataResponseBodyData : TeaModel {
            [NameInMap("DepGroupId")]
            [Validation(Required=false)]
            public string DepGroupId { get; set; }

            [NameInMap("DepGroupName")]
            [Validation(Required=false)]
            public string DepGroupName { get; set; }

            [NameInMap("GroupDTOS")]
            [Validation(Required=false)]
            public List<GetDepGroupTreeDataResponseBodyDataGroupDTOS> GroupDTOS { get; set; }
            public class GetDepGroupTreeDataResponseBodyDataGroupDTOS : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public long? SkillGroupId { get; set; }

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
        public string Success { get; set; }

    }

}
