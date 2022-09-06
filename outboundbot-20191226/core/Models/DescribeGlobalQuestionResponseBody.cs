// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGlobalQuestionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalQuestion")]
        [Validation(Required=false)]
        public DescribeGlobalQuestionResponseBodyGlobalQuestion GlobalQuestion { get; set; }
        public class DescribeGlobalQuestionResponseBodyGlobalQuestion : TeaModel {
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            [NameInMap("GlobalQuestionId")]
            [Validation(Required=false)]
            public string GlobalQuestionId { get; set; }

            [NameInMap("GlobalQuestionName")]
            [Validation(Required=false)]
            public string GlobalQuestionName { get; set; }

            [NameInMap("GlobalQuestionType")]
            [Validation(Required=false)]
            public string GlobalQuestionType { get; set; }

            [NameInMap("Questions")]
            [Validation(Required=false)]
            public string Questions { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

        }

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

    }

}
