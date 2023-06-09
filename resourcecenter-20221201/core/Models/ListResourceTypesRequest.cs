// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListResourceTypesRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The query conditions.
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public List<string> Query { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// For more information about the resource types that are supported by Resource Center, see [Services that work with Resource Center](~~477798~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
