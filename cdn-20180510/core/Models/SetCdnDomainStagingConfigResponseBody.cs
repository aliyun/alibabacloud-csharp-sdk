// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetCdnDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// The list of domain configurations.
        /// </summary>
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public List<SetCdnDomainStagingConfigResponseBodyDomainConfigList> DomainConfigList { get; set; }
        public class SetCdnDomainStagingConfigResponseBodyDomainConfigList : TeaModel {
            /// <summary>
            /// The ID of the configuration.
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
            /// The name of the feature.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
