// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiItemListRequest : TeaModel {
        /// <summary>
        /// The API operation name of the Alibaba Cloud service. Fuzzy match is supported.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The version number of the API.
        /// 
        /// >  You can call the [DescribePopApiVersionList](~~DescribePopApiVersionList~~) operation to query the version number.
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The environment in which the API operation parameters are used. Set the value to online.
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The POP code of the Alibaba Cloud service.
        /// 
        /// >  You can call the [DescribeApiList](~~DescribeApiList~~) operation to query the POP code.
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

    }

}
