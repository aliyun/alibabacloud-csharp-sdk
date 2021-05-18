// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QuerySkillGroupsResponseBody : TeaModel {
        [NameInMap("OnePageSize")]
        [Validation(Required=false)]
        public int? OnePageSize { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("TotalResults")]
        [Validation(Required=false)]
        public int? TotalResults { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySkillGroupsResponseBodyData> Data { get; set; }
        public class QuerySkillGroupsResponseBodyData : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public int? ChannelType { get; set; }

            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public long? SkillGroupId { get; set; }

        }

    }

}
