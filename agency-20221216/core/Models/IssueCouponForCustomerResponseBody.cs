// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class IssueCouponForCustomerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
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

        [NameInMap("data")]
        [Validation(Required=false)]
        public IssueCouponForCustomerResponseBodyData Data { get; set; }
        public class IssueCouponForCustomerResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5075915</para>
            /// </summary>
            [NameInMap("CouponTemplateId")]
            [Validation(Required=false)]
            public long? CouponTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-05 18:24:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111,2222</para>
            /// </summary>
            [NameInMap("Uidlist")]
            [Validation(Required=false)]
            public string Uidlist { get; set; }

        }

    }

}
