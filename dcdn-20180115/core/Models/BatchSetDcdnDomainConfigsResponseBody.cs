// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// The list of domain configurations.
        /// </summary>
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public BatchSetDcdnDomainConfigsResponseBodyDomainConfigList DomainConfigList { get; set; }
        public class BatchSetDcdnDomainConfigsResponseBodyDomainConfigList : TeaModel {
            [NameInMap("DomainConfigModel")]
            [Validation(Required=false)]
            public List<BatchSetDcdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel> DomainConfigModel { get; set; }
            public class BatchSetDcdnDomainConfigsResponseBodyDomainConfigListDomainConfigModel : TeaModel {
                /// <summary>
                /// The ID of the configuration. If 0 is returned, the configuration failed and you need reconfigure this configuration.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The feature name.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
