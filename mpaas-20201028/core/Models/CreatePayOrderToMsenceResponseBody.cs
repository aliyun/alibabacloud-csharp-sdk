// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreatePayOrderToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasOrderCreateResponse")]
        [Validation(Required=false)]
        public CreatePayOrderToMsenceResponseBodyMpaasOrderCreateResponse MpaasOrderCreateResponse { get; set; }
        public class CreatePayOrderToMsenceResponseBodyMpaasOrderCreateResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3929520</para>
            /// </summary>
            [NameInMap("BizOrderId")]
            [Validation(Required=false)]
            public string BizOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
