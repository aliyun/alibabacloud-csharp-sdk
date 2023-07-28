// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// Schema of Response
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// WEB-front-end monitoring
        /// APPLICATION-Application Monitoring
        /// PROMETHEUS-PROM monitoring
        /// SYNTHETICTASK-Cloud dial test
        /// ALERTRULE - Application Monitoring Similar
        /// PROMETHEUSALERTRULE - Prometheus monitoring
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// http://arms.${regionId}.aliyun-inc.com:8099/tag/TagResources.json
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
