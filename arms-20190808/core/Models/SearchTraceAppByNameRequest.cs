// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTraceAppByNameRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<SearchTraceAppByNameRequestTags> Tags { get; set; }
        public class SearchTraceAppByNameRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the application.
        /// 
        /// > If you do not specify this parameter, all application monitoring tasks in the specified region are queried.
        /// </summary>
        [NameInMap("TraceAppName")]
        [Validation(Required=false)]
        public string TraceAppName { get; set; }

    }

}
