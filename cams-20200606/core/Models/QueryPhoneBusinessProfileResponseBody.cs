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
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>OK indicates that the request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneBusinessProfileResponseBodyData Data { get; set; }
        public class QueryPhoneBusinessProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business profile.</para>
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
            /// <para><a href="mailto:example@aliyun.com">example@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The profile picture.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.img">https://example.img</a></para>
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
            /// <para>The websites.</para>
            /// </summary>
            [NameInMap("Websites")]
            [Validation(Required=false)]
            public List<string> Websites { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: failed.</para>
        /// </description></item>
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
