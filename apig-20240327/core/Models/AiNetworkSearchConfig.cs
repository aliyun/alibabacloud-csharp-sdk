// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkSearchConfig : TeaModel {
        [NameInMap("defaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        [NameInMap("defaultLang")]
        [Validation(Required=false)]
        public string DefaultLang { get; set; }

        [NameInMap("needReference")]
        [Validation(Required=false)]
        public bool? NeedReference { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        [NameInMap("referenceFormat")]
        [Validation(Required=false)]
        public string ReferenceFormat { get; set; }

        [NameInMap("referenceLocation")]
        [Validation(Required=false)]
        public string ReferenceLocation { get; set; }

        [NameInMap("searchEngineConfig")]
        [Validation(Required=false)]
        public AiNetworkConfigSearchEngine SearchEngineConfig { get; set; }

        [NameInMap("searchFrom")]
        [Validation(Required=false)]
        public List<AiNetworkConfigSearchEngine> SearchFrom { get; set; }

        [NameInMap("searchRewrite")]
        [Validation(Required=false)]
        public AiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
        public class AiNetworkSearchConfigSearchRewrite : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("maxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

    }

}
