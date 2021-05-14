// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNoticeConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NoticeConfigList")]
        [Validation(Required=false)]
        public List<DescribeNoticeConfigResponseBodyNoticeConfigList> NoticeConfigList { get; set; }
        public class DescribeNoticeConfigResponseBodyNoticeConfigList : TeaModel {
            [NameInMap("TimeLimit")]
            [Validation(Required=false)]
            public int? TimeLimit { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Route")]
            [Validation(Required=false)]
            public int? Route { get; set; }

        }

    }

}
