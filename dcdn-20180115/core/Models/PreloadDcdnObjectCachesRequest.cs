// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PreloadDcdnObjectCachesRequest : TeaModel {
        /// <summary>
        /// The acceleration region in which you want to prefetch content. If you do not specify a region, the value overseas is used.
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: outside the Chinese mainland
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// Specifies whether to prefetch content to POPs. Valid values:
        /// 
        /// *   **true**: prefetches content to nodes that include L2 DCDN nodes.
        /// *   **false**: prefetches content to L2 POPs or L3 POPs.
        /// </summary>
        [NameInMap("L2Preload")]
        [Validation(Required=false)]
        public bool? L2Preload { get; set; }

        /// <summary>
        /// The path of the content that you want to prefetch. Separate multiple URLs with line feed characters (\n) or a pair of carriage return and line feed characters (\r\n).
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The custom header for prefetch in the JSON format.
        /// </summary>
        [NameInMap("WithHeader")]
        [Validation(Required=false)]
        public string WithHeader { get; set; }

    }

}
