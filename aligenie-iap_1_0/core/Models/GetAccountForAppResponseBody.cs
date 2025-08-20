// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetAccountForAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public GetAccountForAppResponseBodyRetValue RetValue { get; set; }
        public class GetAccountForAppResponseBodyRetValue : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsVip")]
            [Validation(Required=false)]
            public bool? IsVip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-12 15:22:18</para>
            /// </summary>
            [NameInMap("StrVipExpire")]
            [Validation(Required=false)]
            public string StrVipExpire { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1652340138347</para>
            /// </summary>
            [NameInMap("VipExpireAt")]
            [Validation(Required=false)]
            public long? VipExpireAt { get; set; }

        }

    }

}
