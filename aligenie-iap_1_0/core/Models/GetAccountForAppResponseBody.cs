// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetAccountForAppResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code returned. A value of <c>0</c> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        /// <summary>
        /// <para>Error message returned. No message is returned upon success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求异常</para>
        /// </summary>
        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        /// <summary>
        /// <para>List of result objects returned.</para>
        /// </summary>
        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public GetAccountForAppResponseBodyRetValue RetValue { get; set; }
        public class GetAccountForAppResponseBodyRetValue : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is an authorized member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsVip")]
            [Validation(Required=false)]
            public bool? IsVip { get; set; }

            /// <summary>
            /// <para>Membership expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-12 15:22:18</para>
            /// </summary>
            [NameInMap("StrVipExpire")]
            [Validation(Required=false)]
            public string StrVipExpire { get; set; }

            /// <summary>
            /// <para>Millisecond-level UNIX timestamp.</para>
            /// <list type="bullet">
            /// <item><description>If the user has activated membership, returns the membership expiration time.</description></item>
            /// <item><description>If the user has never activated membership, the value is always <c>0</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1652340138347</para>
            /// </summary>
            [NameInMap("VipExpireAt")]
            [Validation(Required=false)]
            public long? VipExpireAt { get; set; }

        }

    }

}
