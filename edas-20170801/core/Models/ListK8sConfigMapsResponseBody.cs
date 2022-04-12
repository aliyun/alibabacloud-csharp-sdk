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
        public List<ListK8sConfigMapsResponseBodyResult> Result { get; set; }
        public class ListK8sConfigMapsResponseBodyResult : TeaModel {
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListK8sConfigMapsResponseBodyResultConfigMaps> ConfigMaps { get; set; }
            public class ListK8sConfigMapsResponseBodyResultConfigMaps : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsData> Data { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsData : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps> RelatedApps { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
