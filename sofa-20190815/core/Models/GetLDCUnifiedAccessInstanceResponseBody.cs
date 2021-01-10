// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCUnifiedAccessInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLDCUnifiedAccessInstanceResponseBodyData Data { get; set; }
        public class GetLDCUnifiedAccessInstanceResponseBodyData : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("SpannerCluster")]
            [Validation(Required=false)]
            public string SpannerCluster { get; set; }
            [NameInMap("UnifiedAccessInstanceId")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceId { get; set; }
            [NameInMap("UnifiedAccessInstanceMessageDetails")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceMessageDetails { get; set; }
            [NameInMap("UnifiedAccessInstanceName")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceName { get; set; }
            [NameInMap("UnifiedAccessInstanceStatus")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceStatus { get; set; }
            [NameInMap("UnifiedAccessInstanceType")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceType { get; set; }
            [NameInMap("UnifiedAccessInstanceContainerServiceInfos")]
            [Validation(Required=false)]
            public List<GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceContainerServiceInfos> UnifiedAccessInstanceContainerServiceInfos { get; set; }
            public class GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceContainerServiceInfos : TeaModel {
                public string ContainerServiceName { get; set; }
                public string Namespace { get; set; }
            }
            [NameInMap("UnifiedAccessInstanceLocalDetailInfos")]
            [Validation(Required=false)]
            public List<GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceLocalDetailInfos> UnifiedAccessInstanceLocalDetailInfos { get; set; }
            public class GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceLocalDetailInfos : TeaModel {
                public string ClusterName { get; set; }
                public string DataCenter { get; set; }
                public string MessageDetails { get; set; }
                public string Status { get; set; }
                public string Vip { get; set; }
            }
            [NameInMap("UnifiedAccessInstanceHttpsEntry")]
            [Validation(Required=false)]
            public GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceHttpsEntry UnifiedAccessInstanceHttpsEntry { get; set; }
            public class GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceHttpsEntry : TeaModel {
                [NameInMap("CaCertificateId")]
                [Validation(Required=false)]
                public string CaCertificateId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("WebsocketConnect")]
                [Validation(Required=false)]
                public bool? WebsocketConnect { get; set; }

            }
            [NameInMap("UnifiedAccessInstanceHttpEntry")]
            [Validation(Required=false)]
            public GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceHttpEntry UnifiedAccessInstanceHttpEntry { get; set; }
            public class GetLDCUnifiedAccessInstanceResponseBodyDataUnifiedAccessInstanceHttpEntry : TeaModel {
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("WebsocketConnect")]
                [Validation(Required=false)]
                public bool? WebsocketConnect { get; set; }

            }
        };

    }

}
