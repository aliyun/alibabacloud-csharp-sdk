// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateChatSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>响应码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>响应数据。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateChatSessionResponseBodyData Data { get; set; }
        public class CreateChatSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>端渲染数字人资产信息。</para>
            /// </summary>
            [NameInMap("avatarAssets")]
            [Validation(Required=false)]
            public CreateChatSessionResponseBodyDataAvatarAssets AvatarAssets { get; set; }
            public class CreateChatSessionResponseBodyDataAvatarAssets : TeaModel {
                /// <summary>
                /// <para>资产MD5值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>5B83BE2114489274BB88BADE7EBC****</para>
                /// </summary>
                [NameInMap("md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// <para>支持的SDK最低版本。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("minRequiredVersion")]
                [Validation(Required=false)]
                public string MinRequiredVersion { get; set; }

                /// <summary>
                /// <para>SDK使用的密钥。</para>
                /// 
                /// <b>Example:</b>
                /// <para>J562PNqJBZDhzOQpLBgIcIW8+rHQoM7P6IONGMP7P5vGxrWLxT7VtRenFnMY+wg/zpA2qwpFBmJYO2rVexnlCQ2WE4kvYOH/OKmlTzpQddY34U5jS9KaS3b3ulpq4xnKDjWJ+sLZSRMhuPDdlq8ZPfcfEPhJhF3zPO8Hu4QOSu+D/pAIDJUoixOTo9Q14DXFKGFuuVRQOQ7f/VxJcoSLIWIusV917pLtph/IYBaLd27gzbrTZBEVD8qrucR+WOQPY1g67PGAdafkhJWrs/+coM7+5dc3HEUC+KgI9JN4X4Akelc94aJcy78RZ6tRdr73hBzN83/cMZdzt2hx******</para>
                /// </summary>
                [NameInMap("secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                /// <summary>
                /// <para>资产类型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>AVATAR_3D_TRADITIONAL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>资产下载链接。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://daily-avatar-property.oss-cn-beijing.aliyuncs.com/avatar-share-property/AVATAR_3D_TRADITIONAL/Mt.CNMU6BO4RBYU2/secret_assets_web.zip?Expires=1752637519&OSSAccessKeyId=STS.NZULzwLRx8thHDHQxem94****&Signature=Oni3%2Be8dY8Xrv3iRGDyzn7u****%3D&security-token=CAISzAJ1q6Ft5B2yfSjIr5ngB8DDoY1Zj7aDSmL5tXgwYbYYi5LPrDz2IHhMfnloB%2BEcsfU3nmxT6vkZlrp6SJtIXleCZtF94oxN9h2gb4fb4093DEHt08%2FLI3OaLjKm9u2wCryLYbGwU%2FOpbE%2B%2B5U0X6LDmdDKkckW4OJmS8%2FBOZcgWWQ%2FKBlgvRq0hRG1YpdQdKGHaONu0LxfumRCwNkdzvRdmgm4NgsbWgO%2Fks0KA1QSml7ZP%2B9WuesH0M%2FMBZskvD42Hu8VtbbfE3SJq7BxHybx7lqQs%2B02c5onHUwEPsk%2FZYrKOroYzc1RjAbM%2FErRY6fP8nOE9ovbUm5RXHpT05CrMOs62ZPdDoKOscIvBXr6yZaP7JmcGC6iQLG%2FznQkSc081IsK2C7Xq0pe54O3lg9Ab41ZGNYEjq%2BpCIUP%2Fs97dqXEelD2e%2Bh8UezDnKxqAAXuAiYRY7Ox3cf6h2MlmRsK5yywg45O%2FizjiK2k8Z8p6WeOA54W3pfbg6ElV4d8TMWCVZ7tuAbSgRCKBg3q5YYrdS2ENqDu6njIea1pxG4LT4ydGxDBkYpjwcUxutDd0aAhFjsypSK%2Feuk0%2FDCfKMrWzCmkr1AtPpcNfJ8LPj58qIA">https://daily-avatar-property.oss-cn-beijing.aliyuncs.com/avatar-share-property/AVATAR_3D_TRADITIONAL/Mt.CNMU6BO4RBYU2/secret_assets_web.zip?Expires=1752637519&amp;OSSAccessKeyId=STS.NZULzwLRx8thHDHQxem94****&amp;Signature=Oni3%2Be8dY8Xrv3iRGDyzn7u****%3D&amp;security-token=CAISzAJ1q6Ft5B2yfSjIr5ngB8DDoY1Zj7aDSmL5tXgwYbYYi5LPrDz2IHhMfnloB%2BEcsfU3nmxT6vkZlrp6SJtIXleCZtF94oxN9h2gb4fb4093DEHt08%2FLI3OaLjKm9u2wCryLYbGwU%2FOpbE%2B%2B5U0X6LDmdDKkckW4OJmS8%2FBOZcgWWQ%2FKBlgvRq0hRG1YpdQdKGHaONu0LxfumRCwNkdzvRdmgm4NgsbWgO%2Fks0KA1QSml7ZP%2B9WuesH0M%2FMBZskvD42Hu8VtbbfE3SJq7BxHybx7lqQs%2B02c5onHUwEPsk%2FZYrKOroYzc1RjAbM%2FErRY6fP8nOE9ovbUm5RXHpT05CrMOs62ZPdDoKOscIvBXr6yZaP7JmcGC6iQLG%2FznQkSc081IsK2C7Xq0pe54O3lg9Ab41ZGNYEjq%2BpCIUP%2Fs97dqXEelD2e%2Bh8UezDnKxqAAXuAiYRY7Ox3cf6h2MlmRsK5yywg45O%2FizjiK2k8Z8p6WeOA54W3pfbg6ElV4d8TMWCVZ7tuAbSgRCKBg3q5YYrdS2ENqDu6njIea1pxG4LT4ydGxDBkYpjwcUxutDd0aAhFjsypSK%2Feuk0%2FDCfKMrWzCmkr1AtPpcNfJ8LPj58qIA</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>RTC入参。</para>
            /// </summary>
            [NameInMap("rtcParams")]
            [Validation(Required=false)]
            public CreateChatSessionResponseBodyDataRtcParams RtcParams { get; set; }
            public class CreateChatSessionResponseBodyDataRtcParams : TeaModel {
                /// <summary>
                /// <para>应用id。</para>
                /// 
                /// <b>Example:</b>
                /// <para>895cbf3b</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>数字人侧用户ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>E7enIvjUos</para>
                /// </summary>
                [NameInMap("avatarUserId")]
                [Validation(Required=false)]
                public string AvatarUserId { get; set; }

                /// <summary>
                /// <para>RTC通道ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>pPltqR3FovNCK3hNQc8eHUL3Zt****</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>客户端侧用户ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>aw0tqpFlP4</para>
                /// </summary>
                [NameInMap("clientUserId")]
                [Validation(Required=false)]
                public string ClientUserId { get; set; }

                /// <summary>
                /// <para>RTC服务地址。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.rtn.aliyuncs.com">https://gw.rtn.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("gslb")]
                [Validation(Required=false)]
                public string Gslb { get; set; }

                /// <summary>
                /// <para>随机串。</para>
                /// 
                /// <b>Example:</b>
                /// <para>f8b0ef02c5da778f4488e2470c</para>
                /// </summary>
                [NameInMap("nonce")]
                [Validation(Required=false)]
                public string Nonce { get; set; }

                /// <summary>
                /// <para>服务端侧用户ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>YzZtSQP8QX</para>
                /// </summary>
                [NameInMap("serverUserId")]
                [Validation(Required=false)]
                public string ServerUserId { get; set; }

                /// <summary>
                /// <para>过期时间戳。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1560588594</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>访问凭证token。</para>
                /// 
                /// <b>Example:</b>
                /// <para>PtGgv2dM9F8tEuAtda50c0VNNFjn0WUbyTDPa1im4cUBE****</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

            /// <summary>
            /// <para>会话ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>9827f4bd-5008-4d34-98fb-62598f3ad3b5</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>http响应码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>状态码描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>7239F9E5-A4DB-55BA-B701-0CE47DBDB0A8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
