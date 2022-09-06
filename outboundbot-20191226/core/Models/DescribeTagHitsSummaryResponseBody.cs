// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTagHitsSummaryResponseBody : TeaModel {
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
        public List<DescribeTagHitsSummaryResponseBodyTagGroups> TagGroups { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagGroups : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            [NameInMap("TagGroupIndex")]
            [Validation(Required=false)]
            public int? TagGroupIndex { get; set; }

        }

        [NameInMap("TagHitsList")]
        [Validation(Required=false)]
        public List<DescribeTagHitsSummaryResponseBodyTagHitsList> TagHitsList { get; set; }
        public class DescribeTagHitsSummaryResponseBodyTagHitsList : TeaModel {
            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public string TagGroup { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
