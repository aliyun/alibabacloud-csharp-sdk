// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ObtainApplicationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The application token.</para>
        /// </summary>
        [NameInMap("ApplicationToken")]
        [Validation(Required=false)]
        public ObtainApplicationTokenResponseBodyApplicationToken ApplicationToken { get; set; }
        public class ObtainApplicationTokenResponseBodyApplicationToken : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_na2r73a65s7o4zbs7nj5gxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The application token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SATFwqX8zxGf83pJcJw78KFGjmrft4erWeZYBGS8oE7NN6qoE217yaJpUdMb1UuuGqhDiF43sCA4CF91CTL5iGntqwyLuaAcS9FJ9HfGadE5a7TjiwVafwrBxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationToken")]
            [Validation(Required=false)]
            public string ApplicationToken { get; set; }

            /// <summary>
            /// <para>The application token ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token_m7aso6v4efvu2otfq3jdzxxxx</para>
            /// </summary>
            [NameInMap("ApplicationTokenId")]
            [Validation(Required=false)]
            public string ApplicationTokenId { get; set; }

            /// <summary>
            /// <para>The type of the application token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bearer_token</para>
            /// </summary>
            [NameInMap("ApplicationTokenType")]
            [Validation(Required=false)]
            public string ApplicationTokenType { get; set; }

            /// <summary>
            /// <para>The time when the application token was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735610930000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735610950000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The ID of the IDaaS EIAM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ki6hd7ihir4ybawogqk6kqxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the token was last used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735610930000</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
