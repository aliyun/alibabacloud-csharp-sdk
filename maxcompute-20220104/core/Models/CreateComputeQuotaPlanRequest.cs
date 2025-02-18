// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateComputeQuotaPlanRequest : TeaModel {
        /// <summary>
        /// <para>The name of quota plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>planA</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parameters of quota plan.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public CreateComputeQuotaPlanRequestQuota Quota { get; set; }
        public class CreateComputeQuotaPlanRequestQuota : TeaModel {
            /// <summary>
            /// <para>The parameters of level-1 quota.</para>
            /// </summary>
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public CreateComputeQuotaPlanRequestQuotaParameter Parameter { get; set; }
            public class CreateComputeQuotaPlanRequestQuotaParameter : TeaModel {
                /// <summary>
                /// <para>The value of elastic Reserved CUs in the level-1 quota.</para>
                /// <remarks>
                /// <para>The default value is 0. The maximum value of this parameter must be equal to the number of subscription-based reserved CUs and cannot exceed 10,000 CUs.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("elasticReservedCU")]
                [Validation(Required=false)]
                public long? ElasticReservedCU { get; set; }

            }

            /// <summary>
            /// <para>The list of level-2 quotas.</para>
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<CreateComputeQuotaPlanRequestQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class CreateComputeQuotaPlanRequestQuotaSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The nickname of the level-2 quota.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>os_ComputeQuota</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The parameters of the level-2 quota.</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public CreateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter Parameter { get; set; }
                public class CreateComputeQuotaPlanRequestQuotaSubQuotaInfoListParameter : TeaModel {
                    /// <summary>
                    /// <para>The value of elastic Reserved CUs.</para>
                    /// <remarks>
                    /// <para>The total number of elastically reserved CUs in all the level-2 quotas is equal to the number of elastically reserved CUs in the level-1 quota.</para>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    /// <summary>
                    /// <para>The value of maxCU in Reserved CUs.</para>
                    /// <remarks>
                    /// <para>The value of maxCU must be less than or equal to the value of maxCU in the level-1 quota that you purchased.</para>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    /// <summary>
                    /// <para>The value of minCU in Reserved CUs.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>The total value of minCU in all the level-2 quotas is equal to the value of minCU in the level-1 quota.</description></item>
                    /// <item><description>The value of minCU must be less than or equal to the value of maxCU in the level-2 quota and less than or equal to the value of minCU in the level-1 quota that you purchased.</description></item>
                    /// </list>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                }

            }

        }

    }

}
