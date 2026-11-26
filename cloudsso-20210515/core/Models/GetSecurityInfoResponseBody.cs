// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetSecurityInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE42D2C4-A30A-59B7-ACEB-6D22FB44174A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security email information of the user.</para>
        /// <remarks>
        /// <para>If the user has not configured a security email address, this field is not returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SecurityEmail")]
        [Validation(Required=false)]
        public GetSecurityInfoResponseBodySecurityEmail SecurityEmail { get; set; }
        public class GetSecurityInfoResponseBodySecurityEmail : TeaModel {
            /// <summary>
            /// <para>The security email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:Alice@example.com">Alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The verification status of the security email address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: Verified.</description></item>
            /// <item><description>pending: Pending verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
