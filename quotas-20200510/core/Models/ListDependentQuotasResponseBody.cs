// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListDependentQuotasResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The list of quotas on which the target quota depends.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListDependentQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListDependentQuotasResponseBodyQuotas : Darabonba.Model {
            /// <summary>
            /// <para>The quota dimensions on which the target quota depends.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ListDependentQuotasResponseBodyQuotasDimensions> Dimensions { get; set; }
            public class ListDependentQuotasResponseBodyQuotasDimensions : Darabonba.Model {
                /// <summary>
                /// <para>The quota dimension on which the dependent dimension of the target quota depends.</para>
                /// </summary>
                [NameInMap("DependentDimension")]
                [Validation(Required=false)]
                public List<string> DependentDimension { get; set; }

                /// <summary>
                /// <para>The key of the quota dimension on which the target quota depends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The value of the quota dimension on which the dependent dimension of the target quota depends.</para>
                /// </summary>
                [NameInMap("DimensionValues")]
                [Validation(Required=false)]
                public List<string> DimensionValues { get; set; }

            }

            /// <summary>
            /// <para>The abbreviated name of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the quota on which the target quota depends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_laxtn4</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The ratio between the target quota and the dependent quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
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

