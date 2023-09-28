// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdatePortfolioRequest : TeaModel {
        /// <summary>
        /// 产品组合描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 代表资源一级ID的资源属性字段
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 代表资源名称的资源属性字段
        /// </summary>
        [NameInMap("PortfolioName")]
        [Validation(Required=false)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// 产品组合提供方
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

    }

}
