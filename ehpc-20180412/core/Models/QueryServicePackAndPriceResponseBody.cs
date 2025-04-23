// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class QueryServicePackAndPriceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>167</para>
        /// </summary>
        [NameInMap("ChargeAmount")]
        [Validation(Required=false)]
        public int? ChargeAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.418</para>
        /// </summary>
        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3191</para>
        /// </summary>
        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public int? OriginalAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.34</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3B2E8108-7068-413E-BCA7-CAAB25D46408</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServicePack")]
        [Validation(Required=false)]
        public QueryServicePackAndPriceResponseBodyServicePack ServicePack { get; set; }
        public class QueryServicePackAndPriceResponseBodyServicePack : TeaModel {
            [NameInMap("ServicePackInfo")]
            [Validation(Required=false)]
            public List<QueryServicePackAndPriceResponseBodyServicePackServicePackInfo> ServicePackInfo { get; set; }
            public class QueryServicePackAndPriceResponseBodyServicePackServicePackInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1612705988</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EHPCBAG-cn-78v12vbme0****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1610027588</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public int? StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.922</para>
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
