// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCUnifiedAccessInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryLDCUnifiedAccessInstanceResponseBodyList> List { get; set; }
        public class QueryLDCUnifiedAccessInstanceResponseBodyList : TeaModel {
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
            public List<QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceContainerServiceInfos> UnifiedAccessInstanceContainerServiceInfos { get; set; }
            public class QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceContainerServiceInfos : TeaModel {
                [NameInMap("ContainerServiceName")]
                [Validation(Required=false)]
                public string ContainerServiceName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

            [NameInMap("UnifiedAccessInstanceLocalDetailInfos")]
            [Validation(Required=false)]
            public List<QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceLocalDetailInfos> UnifiedAccessInstanceLocalDetailInfos { get; set; }
            public class QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceLocalDetailInfos : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public string DataCenter { get; set; }

                [NameInMap("MessageDetails")]
                [Validation(Required=false)]
                public string MessageDetails { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

            }

            [NameInMap("UnifiedAccessInstanceHttpsEntry")]
            [Validation(Required=false)]
            public QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceHttpsEntry UnifiedAccessInstanceHttpsEntry { get; set; }
            public class QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceHttpsEntry : TeaModel {
                [NameInMap("CaCertificateId")]
                [Validation(Required=false)]
                public string CaCertificateId { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }
                [NameInMap("WebsocketConnect")]
                [Validation(Required=false)]
                public bool? WebsocketConnect { get; set; }
            };

            [NameInMap("UnifiedAccessInstanceHttpEntry")]
            [Validation(Required=false)]
            public QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceHttpEntry UnifiedAccessInstanceHttpEntry { get; set; }
            public class QueryLDCUnifiedAccessInstanceResponseBodyListUnifiedAccessInstanceHttpEntry : TeaModel {
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }
                [NameInMap("WebsocketConnect")]
                [Validation(Required=false)]
                public bool? WebsocketConnect { get; set; }
            };

        }

    }

}
