// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMappingResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveDomainModels")]
        [Validation(Required=true)]
        public DescribeLiveDomainMappingResponseLiveDomainModels LiveDomainModels { get; set; }
        public class DescribeLiveDomainMappingResponseLiveDomainModels : TeaModel {
            [NameInMap("LiveDomainModel")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainMappingResponseLiveDomainModelsLiveDomainModel> LiveDomainModel { get; set; }
            public class DescribeLiveDomainMappingResponseLiveDomainModelsLiveDomainModel : TeaModel {
                public string DomainName { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
