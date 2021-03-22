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
            public GetMetaProductListResponseBodyMetaDataProductsNormal ProductsNormal { get; set; }
            public class GetMetaProductListResponseBodyMetaDataProductsNormal : TeaModel {
                [NameInMap("SpecVO")]
                [Validation(Required=false)]
                public List<GetMetaProductListResponseBodyMetaDataProductsNormalSpecVO> SpecVO { get; set; }
                public class GetMetaProductListResponseBodyMetaDataProductsNormalSpecVO : TeaModel {
                    [NameInMap("TopicQuota")]
                    [Validation(Required=false)]
                    public string TopicQuota { get; set; }

                    [NameInMap("SpecType")]
                    [Validation(Required=false)]
                    public string SpecType { get; set; }

                    [NameInMap("DeployType")]
                    [Validation(Required=false)]
                    public string DeployType { get; set; }

                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public string DiskSize { get; set; }

                    [NameInMap("IoMax")]
                    [Validation(Required=false)]
                    public long? IoMax { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

            }
            [NameInMap("ProductsProfessional")]
            [Validation(Required=false)]
            public GetMetaProductListResponseBodyMetaDataProductsProfessional ProductsProfessional { get; set; }
            public class GetMetaProductListResponseBodyMetaDataProductsProfessional : TeaModel {
                [NameInMap("SpecVO")]
                [Validation(Required=false)]
                public List<GetMetaProductListResponseBodyMetaDataProductsProfessionalSpecVO> SpecVO { get; set; }
                public class GetMetaProductListResponseBodyMetaDataProductsProfessionalSpecVO : TeaModel {
                    [NameInMap("TopicQuota")]
                    [Validation(Required=false)]
                    public string TopicQuota { get; set; }

                    [NameInMap("SpecType")]
                    [Validation(Required=false)]
                    public string SpecType { get; set; }

                    [NameInMap("DeployType")]
                    [Validation(Required=false)]
                    public string DeployType { get; set; }

                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public string DiskSize { get; set; }

                    [NameInMap("IoMax")]
                    [Validation(Required=false)]
                    public int? IoMax { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

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
