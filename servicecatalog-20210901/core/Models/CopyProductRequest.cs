// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CopyProductRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the source product.
        /// 
        /// > The source product can belong to the current account or belong to a product portfolio that is shared by another account.
        /// </summary>
        [NameInMap("SourceProductArn")]
        [Validation(Required=false)]
        public string SourceProductArn { get; set; }

        /// <summary>
        /// The name of the destination product.
        /// </summary>
        [NameInMap("TargetProductName")]
        [Validation(Required=false)]
        public string TargetProductName { get; set; }

    }

}
