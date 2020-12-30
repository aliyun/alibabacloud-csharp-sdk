// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListCommonGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<ListCommonGroupResponseBodyObject> Object { get; set; }
        public class ListCommonGroupResponseBodyObject : TeaModel {
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public int? ResourceCount { get; set; }

            [NameInMap("SmartGroupId")]
            [Validation(Required=false)]
            public string SmartGroupId { get; set; }

            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public bool? IsRoot { get; set; }

            [NameInMap("Pinyin")]
            [Validation(Required=false)]
            public string Pinyin { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
