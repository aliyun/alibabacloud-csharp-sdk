// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListTagsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTagGroups> TagGroups { get; set; }
        public class ListTagsResponseBodyTagGroups : TeaModel {
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            [NameInMap("TagGroupId")]
            [Validation(Required=false)]
            public string TagGroupId { get; set; }

            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTags> Tags { get; set; }
        public class ListTagsResponseBodyTags : TeaModel {
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            [NameInMap("TagIndex")]
            [Validation(Required=false)]
            public int? TagIndex { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
