// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCommissionableProductsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCommissionableProductsResponseBodyData> Data { get; set; }
        public class GetCommissionableProductsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>“202502”</para>
            /// </summary>
            [NameInMap("ActualStartMonth")]
            [Validation(Required=false)]
            public string ActualStartMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“oceanbase_obpre_public_intl”</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“ApsaraDB for OceanBase Pre”</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("EligibleForCommission")]
            [Validation(Required=false)]
            public string EligibleForCommission { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("EligibleForDiscount")]
            [Validation(Required=false)]
            public string EligibleForDiscount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“202509”</para>
            /// </summary>
            [NameInMap("EndMonth")]
            [Validation(Required=false)]
            public string EndMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("ProductCampaign")]
            [Validation(Required=false)]
            public string ProductCampaign { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“oceanbase”</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“ApsaraDB for OceanBase”</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("SevenCoreProducts")]
            [Validation(Required=false)]
            public string SevenCoreProducts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“ONLINE”</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2103a30617045934095083027d88c5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
