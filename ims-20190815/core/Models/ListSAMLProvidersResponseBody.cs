// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListSAMLProvidersResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the response is truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The `marker`. This parameter is returned only if the value of `IsTruncated` is `true`. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the IdP.
        /// </summary>
        [NameInMap("SAMLProviders")]
        [Validation(Required=false)]
        public ListSAMLProvidersResponseBodySAMLProviders SAMLProviders { get; set; }
        public class ListSAMLProvidersResponseBodySAMLProviders : TeaModel {
            [NameInMap("SAMLProvider")]
            [Validation(Required=false)]
            public List<ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider> SAMLProvider { get; set; }
            public class ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the IdP.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the IdP.
                /// </summary>
                [NameInMap("SAMLProviderName")]
                [Validation(Required=false)]
                public string SAMLProviderName { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

    }

}
