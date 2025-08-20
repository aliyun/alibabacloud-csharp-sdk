// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetBusAppConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请求异常</para>
        /// </summary>
        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public GetBusAppConfigResponseBodyRetValue RetValue { get; set; }
        public class GetBusAppConfigResponseBodyRetValue : TeaModel {
            [NameInMap("Cashier")]
            [Validation(Required=false)]
            public string Cashier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.com/design/</b></b></b>?imageId=xxxxx</para>
            /// </summary>
            [NameInMap("ShoppingBar")]
            [Validation(Required=false)]
            public string ShoppingBar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.com/design/</b></b></b>?imageId=xxxxx</para>
            /// </summary>
            [NameInMap("ShoppingWindow")]
            [Validation(Required=false)]
            public string ShoppingWindow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.com/design/</b></b></b>?imageId=xxxxx</para>
            /// </summary>
            [NameInMap("VipLabel")]
            [Validation(Required=false)]
            public string VipLabel { get; set; }

        }

    }

}
