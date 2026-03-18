// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeQuotaPlanRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public UpdateComputeQuotaPlanRequestQuota Quota { get; set; }
        public class UpdateComputeQuotaPlanRequestQuota : TeaModel {
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public UpdateComputeQuotaPlanRequestQuotaParameter Parameter { get; set; }
            public class UpdateComputeQuotaPlanRequestQuotaParameter : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("elasticReservedCU")]
                [Validation(Required=false)]
                public long? ElasticReservedCU { get; set; }

            }

            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<UpdateComputeQuotaPlanRequestQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class UpdateComputeQuotaPlanRequestQuotaSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("parameter")]
                [Validation(Required=false)]
                public UpdateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter Parameter { get; set; }
                public class UpdateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter : TeaModel {
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
