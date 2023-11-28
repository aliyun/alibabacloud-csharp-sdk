// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 1d2db86sca4384811e0b5e8707e\*\*\*\*\*\*
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Page { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// \[{"key":"env","value","dev"},{"key":"dev", "value":"IT"}]
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// \["es-cn-aaa","es-cn-bbb"]
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Size { get; set; }

        /// <summary>
        /// The header of the response. This parameter is empty and is for reference only. You cannot force this parameter to be relied on in the program.
        /// 
        /// >  The return examples does not contain this parameter.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
