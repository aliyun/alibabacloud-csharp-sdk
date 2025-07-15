// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMappingResponseBody : TeaModel {
        /// <summary>
        /// <para>The mappings of the queried domain name.</para>
        /// </summary>
        [NameInMap("LiveDomainModels")]
        [Validation(Required=false)]
        public DescribeLiveDomainMappingResponseBodyLiveDomainModels LiveDomainModels { get; set; }
        public class DescribeLiveDomainMappingResponseBodyLiveDomainModels : TeaModel {
            [NameInMap("LiveDomainModel")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainMappingResponseBodyLiveDomainModelsLiveDomainModel> LiveDomainModel { get; set; }
            public class DescribeLiveDomainMappingResponseBodyLiveDomainModelsLiveDomainModel : TeaModel {
                /// <summary>
                /// <para>The domain name to which the queried domain name is mapped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The type of the queried domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vhost</b>: main streaming domain</description></item>
                /// <item><description><b>publish</b>: ingest domain</description></item>
                /// <item><description><b>play</b>: sub-streaming domain</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>play</para>
                /// </summary>
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
