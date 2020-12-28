// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetMetaProductListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public GetMetaProductListResponseBodyMetaData MetaData { get; set; }
        public class GetMetaProductListResponseBodyMetaData : TeaModel {
            [NameInMap("ProductsNormal")]
            [Validation(Required=false)]
            public List<GetMetaProductListResponseBodyMetaDataProductsNormal> ProductsNormal { get; set; }
            public class GetMetaProductListResponseBodyMetaDataProductsNormal : TeaModel {
                public string TopicQuota { get; set; }
                public string SpecType { get; set; }
                public string DeployType { get; set; }
                public string DiskSize { get; set; }
                public long? IoMax { get; set; }
                public string DiskType { get; set; }
                public string RegionId { get; set; }
            }
            [NameInMap("ProductsProfessional")]
            [Validation(Required=false)]
            public List<GetMetaProductListResponseBodyMetaDataProductsProfessional> ProductsProfessional { get; set; }
            public class GetMetaProductListResponseBodyMetaDataProductsProfessional : TeaModel {
                public string TopicQuota { get; set; }
                public string SpecType { get; set; }
                public string DeployType { get; set; }
                public string DiskSize { get; set; }
                public int? IoMax { get; set; }
                public string DiskType { get; set; }
                public string RegionId { get; set; }
            }
            [NameInMap("Names")]
            [Validation(Required=false)]
            public Dictionary<string, string> Names { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
