// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCouponTemplateResponseBodyData Data { get; set; }
        public class CreateCouponTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("ApplicableProducts")]
            [Validation(Required=false)]
            public string ApplicableProducts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Partner</para>
            /// </summary>
            [NameInMap("CostBearer")]
            [Validation(Required=false)]
            public string CostBearer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("CouponTemplateID")]
            [Validation(Required=false)]
            public long? CouponTemplateID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-02 16:15:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("Expireddate")]
            [Validation(Required=false)]
            public string Expireddate { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public List<string> ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("Vailddate")]
            [Validation(Required=false)]
            public string Vailddate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vaildperioddays")]
            [Validation(Required=false)]
            public string Vaildperioddays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Validity Duration</para>
            /// </summary>
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public string ValidUntil { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
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

    }

}
