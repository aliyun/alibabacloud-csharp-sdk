// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetMyAgenticNotificationChannelAuthorizeUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization URL information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMyAgenticNotificationChannelAuthorizeUrlResponseBodyData Data { get; set; }
        public class GetMyAgenticNotificationChannelAuthorizeUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the Lark OAuth authorization page. After the user opens the URL in a browser and completes the authorization, the system binds the Lark account as the notification identity for the current user, and the channel switch remains unchanged. The state parameter in the URL is valid for 180 seconds and can be used only once.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://open.feishu.cn/open-apis/authen/v1/authorize?app_id=cli_a5f8e2d9c3b1****&redirect_uri=https%3A%2F%2Faig-dms-cn-hangzhou.aliyuncs.com%2Foauth%2Fmobile%2Ffeishu%2Fbind&state=eyJhbGciOiJIUzI1NiJ9">https://open.feishu.cn/open-apis/authen/v1/authorize?app_id=cli_a5f8e2d9c3b1****&amp;redirect_uri=https%3A%2F%2Faig-dms-cn-hangzhou.aliyuncs.com%2Foauth%2Fmobile%2Ffeishu%2Fbind&amp;state=eyJhbGciOiJIUzI1NiJ9</a>****</para>
            /// </summary>
            [NameInMap("AuthorizeUrl")]
            [Validation(Required=false)]
            public string AuthorizeUrl { get; set; }

            /// <summary>
            /// <para>The callback URL after the authorization is completed. You must add this URL to the redirect URL whitelist of the tenant\&quot;s Lark application. Otherwise, the authorization fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aig-dms-cn-hangzhou.aliyuncs.com/oauth/mobile/feishu/bind">https://aig-dms-cn-hangzhou.aliyuncs.com/oauth/mobile/feishu/bind</a></para>
            /// </summary>
            [NameInMap("RedirectUri")]
            [Validation(Required=false)]
            public string RedirectUri { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_PARAMETER</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel must be FEISHU</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
