// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespacedConfigMapsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacedConfigMapsResponseBodyData Data { get; set; }
        public class ListNamespacedConfigMapsResponseBodyData : TeaModel {
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListNamespacedConfigMapsResponseBodyDataConfigMaps> ConfigMaps { get; set; }
            public class ListNamespacedConfigMapsResponseBodyDataConfigMaps : TeaModel {
                public long? ConfigMapId { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Data { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string NamespaceId { get; set; }
                public List<ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps> RelateApps { get; set; }
                public class ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps : TeaModel {
                    public string AppId { get; set; }
                    public string AppName { get; set; }
                }
                public long? UpdateTime { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
