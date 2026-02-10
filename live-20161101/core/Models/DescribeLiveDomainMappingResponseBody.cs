// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMappingResponseBody : TeaModel {
        [NameInMap("LiveDomainModels")]
        [Validation(Required=false)]
        public DescribeLiveDomainMappingResponseBodyLiveDomainModels LiveDomainModels { get; set; }
        public class DescribeLiveDomainMappingResponseBodyLiveDomainModels : TeaModel {
            [NameInMap("LiveDomainModel")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainMappingResponseBodyLiveDomainModelsLiveDomainModel> LiveDomainModel { get; set; }
            public class DescribeLiveDomainMappingResponseBodyLiveDomainModelsLiveDomainModel : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F6CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
