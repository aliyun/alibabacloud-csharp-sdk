// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sConfigMapsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sConfigMapsResponseBodyResult Result { get; set; }
        public class ListK8sConfigMapsResponseBodyResult : TeaModel {
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListK8sConfigMapsResponseBodyResultConfigMaps> ConfigMaps { get; set; }
            public class ListK8sConfigMapsResponseBodyResultConfigMaps : TeaModel {
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string CreationTime { get; set; }
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsData> Data { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Name { get; set; }
                public string Namespace { get; set; }
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps> RelatedApps { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps : TeaModel {
                    public string AppId { get; set; }
                    public string AppName { get; set; }
                }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

    }

}
