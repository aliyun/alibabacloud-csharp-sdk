// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventPageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeEventPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeEventPageListResponseBodyResultObject : TeaModel {
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<DescribeEventPageListResponseBodyResultObjectChildren> Children { get; set; }
            public class DescribeEventPageListResponseBodyResultObjectChildren : TeaModel {
                [NameInMap("eventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                [NameInMap("eventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("eventStatus")]
                [Validation(Required=false)]
                public string EventStatus { get; set; }

                [NameInMap("eventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("ruleCount")]
                [Validation(Required=false)]
                public long? RuleCount { get; set; }

            }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("eventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ruleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("userCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
