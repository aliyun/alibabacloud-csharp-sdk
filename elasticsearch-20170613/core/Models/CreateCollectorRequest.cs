// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateCollectorRequest : TeaModel {
        [NameInMap("collectorPaths")]
        [Validation(Required=false)]
        public List<string> CollectorPaths { get; set; }

        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<CreateCollectorRequestConfigs> Configs { get; set; }
        public class CreateCollectorRequestConfigs : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("extendConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtendConfigs { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        [NameInMap("resVersion")]
        [Validation(Required=false)]
        public string ResVersion { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the created crawer.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
