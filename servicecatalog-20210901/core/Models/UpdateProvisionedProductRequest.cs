// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateProvisionedProductRequest : TeaModel {
        /// <summary>
        /// The input parameters of the template.
        /// 
        /// You can specify up to 200 parameters.
        /// 
        /// > - This parameter is optional. If you specify the Parameters parameter, you must specify the ParameterKey and ParameterValue parameters.
        /// > - If the values of the ProductVersionId and Parameters parameters are not changed, you are not allowed to update the information about the product instance.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductRequestParameters> Parameters { get; set; }
        public class UpdateProvisionedProductRequestParameters : TeaModel {
            /// <summary>
            /// The name of the input parameter for the template.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the input parameter for the template.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the product portfolio.
        /// 
        /// > The PortfolioId parameter is not required if the default launch option exists. The PortfolioId parameter is required if the default launch option does not exist. For more information about how to obtain the value of the PortfolioId parameter, see [ListLaunchOptions](~~ListLaunchOptions~~).
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The ID of the product.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The ID of the product version.
        /// 
        /// > If the values of the ProductVersionId and Parameters parameters are not changed, the information about the product instance cannot be updated.
        /// </summary>
        [NameInMap("ProductVersionId")]
        [Validation(Required=false)]
        public string ProductVersionId { get; set; }

        /// <summary>
        /// The ID of the product instance.
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// The input custom tags.
        /// 
        /// Maximum value of N: 20.
        /// 
        /// > - The Tags parameter is optional. If you need to specify the Tags parameter, you must specify the Tags.N.Key and Tags.N.Value parameters.
        /// > - The tag is propagated to each stack resource that supports the tag feature.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateProvisionedProductRequestTags> Tags { get; set; }
        public class UpdateProvisionedProductRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the custom tag.
            /// 
            /// The tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the custom tag.
            /// 
            /// The tag value can be up to 128 characters in length and cannot start with `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
