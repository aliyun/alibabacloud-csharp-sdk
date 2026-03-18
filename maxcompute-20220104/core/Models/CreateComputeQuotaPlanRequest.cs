// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateComputeQuotaPlanRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public CreateComputeQuotaPlanRequestQuota Quota { get; set; }
        public class CreateComputeQuotaPlanRequestQuota : TeaModel {
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public CreateComputeQuotaPlanRequestQuotaParameter Parameter { get; set; }
            public class CreateComputeQuotaPlanRequestQuotaParameter : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("elasticReservedCU")]
                [Validation(Required=false)]
                public long? ElasticReservedCU { get; set; }

            }

            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<CreateComputeQuotaPlanRequestQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class CreateComputeQuotaPlanRequestQuotaSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("parameter")]
                [Validation(Required=false)]
                public CreateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter Parameter { get; set; }
                public class CreateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                }

            }

        }

    }

}
