// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsSGFormConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AuthRuleConfig")]
        [Validation(Required=false)]
        public QueryMsSGFormConfigResponseBodyAuthRuleConfig AuthRuleConfig { get; set; }
        public class QueryMsSGFormConfigResponseBodyAuthRuleConfig : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<QueryMsSGFormConfigResponseBodyAuthRuleConfigFields> Fields { get; set; }
            public class QueryMsSGFormConfigResponseBodyAuthRuleConfigFields : TeaModel {
                public string DescCn { get; set; }
                public string DescEn { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<QueryMsSGFormConfigResponseBodyAuthRuleConfigOperations> Operations { get; set; }
            public class QueryMsSGFormConfigResponseBodyAuthRuleConfigOperations : TeaModel {
                public string DescCn { get; set; }
                public string DescEn { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Types")]
            [Validation(Required=false)]
            public List<QueryMsSGFormConfigResponseBodyAuthRuleConfigTypes> Types { get; set; }
            public class QueryMsSGFormConfigResponseBodyAuthRuleConfigTypes : TeaModel {
                public string DescCn { get; set; }
                public string DescEn { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
