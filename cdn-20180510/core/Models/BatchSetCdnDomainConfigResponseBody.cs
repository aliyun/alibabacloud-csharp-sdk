// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchSetCdnDomainConfigResponseBody : TeaModel {
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public BatchSetCdnDomainConfigResponseBodyDomainConfigList DomainConfigList { get; set; }
        public class BatchSetCdnDomainConfigResponseBodyDomainConfigList : TeaModel {
            [NameInMap("DomainConfigModel")]
            [Validation(Required=false)]
            public List<BatchSetCdnDomainConfigResponseBodyDomainConfigListDomainConfigModel> DomainConfigModel { get; set; }
            public class BatchSetCdnDomainConfigResponseBodyDomainConfigListDomainConfigModel : TeaModel {
                public long? ConfigId { get; set; }
                public string DomainName { get; set; }
                public string FunctionName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
