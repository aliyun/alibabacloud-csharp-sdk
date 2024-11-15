// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryPhoneBusinessProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the call is successful.</description></item>
        /// <item><description>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneBusinessProfileResponseBodyData Data { get; set; }
        public class QueryPhoneBusinessProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Regarding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business profile</para>
            /// </summary>
            [NameInMap("About")]
            [Validation(Required=false)]
            public string About { get; set; }

            /// <summary>
            /// <para>The address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Changsha</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:aa@aliyun.com">aa@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The profile picture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://....img</para>
            /// </summary>
            [NameInMap("ProfilePictureUrl")]
            [Validation(Required=false)]
            public string ProfilePictureUrl { get; set; }

            /// <summary>
            /// <para>The industry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Retail</para>
            /// </summary>
            [NameInMap("Vertical")]
            [Validation(Required=false)]
            public string Vertical { get; set; }

            /// <summary>
            /// <para>The website.</para>
            /// </summary>
            [NameInMap("Websites")]
            [Validation(Required=false)]
            public List<string> Websites { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
