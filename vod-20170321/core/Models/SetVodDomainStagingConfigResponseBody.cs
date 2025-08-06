// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetVodDomainStagingConfigResponseBody : TeaModel {
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public List<SetVodDomainStagingConfigResponseBodyDomainConfigList> DomainConfigList { get; set; }
        public class SetVodDomainStagingConfigResponseBodyDomainConfigList : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
