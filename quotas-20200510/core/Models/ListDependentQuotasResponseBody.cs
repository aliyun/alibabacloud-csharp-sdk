// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListDependentQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The quotas on which the specified quota depends.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListDependentQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListDependentQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The dimensions of the quotas on which the specified quota depends.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ListDependentQuotasResponseBodyQuotasDimensions> Dimensions { get; set; }
            public class ListDependentQuotasResponseBodyQuotasDimensions : TeaModel {
                /// <summary>
                /// <para>The dimensions of the quotas on which the specified quota depends.</para>
                /// </summary>
                [NameInMap("DependentDimension")]
                [Validation(Required=false)]
                public List<string> DependentDimension { get; set; }

                /// <summary>
                /// <para>The key of the quota dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>regionId</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The dimension values.</para>
                /// </summary>
                [NameInMap("DimensionValues")]
                [Validation(Required=false)]
                public List<string> DimensionValues { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_elastic-network-interfaces</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The relationship percentage between the specified quota and the quotas on which the specified quota depends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Scale")]
            [Validation(Required=false)]
            public float? Scale { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>920D8A47-26BB-49FA-A09F-F98D7DAA55F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
