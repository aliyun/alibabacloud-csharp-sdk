// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete all tags. This parameter takes effect only when the TagKey.N parameter is not specified. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The resource IDs. You can specify a maximum of 50 resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the ARMS resources for which you want to modify tags. Valid values:
        /// 
        /// *   WEB: Browser Monitoring
        /// *   APPLICATION: Application Monitoring
        /// *   PROMETHEUS: Managed Service for Prometheus
        /// *   SYNTHETICTASK: Synthetic Monitoring
        /// *   ALERTRULE: Application Monitoring alert rule
        /// *   PROMETHEUSALERTRULE: Managed Service for Prometheus alert rule
        /// *   XTRACEAPP: Managed Service for OpenTelemetry
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag keys. You can specify a maximum of 20 tag keys.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UntagResourcesRequestTags> Tags { get; set; }
        public class UntagResourcesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
