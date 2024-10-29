// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetIdpConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIdpConfigResponseBodyData Data { get; set; }
        public class GetIdpConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>AccessKey ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI5tJVztnh6Nn***</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>AccessKey Secret</para>
            /// 
            /// <b>Example:</b>
            /// <para>E75ktr5jENiR3ssjC***</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://172.10.10.2:4321/getGroup?name=%s&pass=%s">https://172.10.10.2:4321/getGroup?name=%s&amp;pass=%s</a></para>
            /// </summary>
            [NameInMap("GetGroupUrl")]
            [Validation(Required=false)]
            public string GetGroupUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1465</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <?xml version="1.0" encoding="utf-8"?><hr>
            /// </summary>
            [NameInMap("IdpMetadata")]
            [Validation(Required=false)]
            public string IdpMetadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MfaConfigType")]
            [Validation(Required=false)]
            public string MfaConfigType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("MobileLoginType")]
            [Validation(Required=false)]
            public string MobileLoginType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>totp</para>
            /// </summary>
            [NameInMap("MobileMfaConfigType")]
            [Validation(Required=false)]
            public string MobileMfaConfigType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1482,1355</para>
            /// </summary>
            [NameInMap("MultiIdpInfo")]
            [Validation(Required=false)]
            public string MultiIdpInfo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("PcLoginType")]
            [Validation(Required=false)]
            public string PcLoginType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CSAS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-02-26T02:02:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QVhaU0RDR0JIWVV***</para>
            /// </summary>
            [NameInMap("VerifyAesKey")]
            [Validation(Required=false)]
            public string VerifyAesKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7JAr3fYtnl***</para>
            /// </summary>
            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://172.10.10.1:1234/otp_verify">http://172.10.10.1:1234/otp_verify</a></para>
            /// </summary>
            [NameInMap("VerifyUrl")]
            [Validation(Required=false)]
            public string VerifyUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
