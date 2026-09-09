// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorAuthenticationInput : TeaModel {
        /// <summary>
        /// <para>Authenticates by using a username and password.</para>
        /// </summary>
        [NameInMap("basic")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputBasic Basic { get; set; }
        public class ConnectorAuthenticationInputBasic : TeaModel {
            /// <summary>
            /// <para>Password</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-password</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>Username</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>starops</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>Authenticates by using a bot token and a signing key.</para>
        /// </summary>
        [NameInMap("botToken")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputBotToken BotToken { get; set; }
        public class ConnectorAuthenticationInputBotToken : TeaModel {
            /// <summary>
            /// <para>Bot token</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bot-token</para>
            /// </summary>
            [NameInMap("botToken")]
            [Validation(Required=false)]
            public string BotToken { get; set; }

            /// <summary>
            /// <para>Signing secret</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-signing-secret</para>
            /// </summary>
            [NameInMap("signingSecret")]
            [Validation(Required=false)]
            public string SigningSecret { get; set; }

        }

        /// <summary>
        /// <para>Authenticates by using an OAuth client identity.</para>
        /// </summary>
        [NameInMap("oauth")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputOauth Oauth { get; set; }
        public class ConnectorAuthenticationInputOauth : TeaModel {
            /// <summary>
            /// <para>OAuth client ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client-id</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>OAuth client secret</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-client-secret</para>
            /// </summary>
            [NameInMap("clientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

        }

        /// <summary>
        /// <para>Authenticates by using a personal access token.</para>
        /// </summary>
        [NameInMap("patToken")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputPatToken PatToken { get; set; }
        public class ConnectorAuthenticationInputPatToken : TeaModel {
            /// <summary>
            /// <para>The personal access token used to access the target service.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-personal-access-token</para>
            /// </summary>
            [NameInMap("patToken")]
            [Validation(Required=false)]
            public string PatToken { get; set; }

        }

        /// <summary>
        /// <para>Authenticates by using a RAM role ARN.</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputRole Role { get; set; }
        public class ConnectorAuthenticationInputRole : TeaModel {
            /// <summary>
            /// <para>Role ARN</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/starops-reader</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

        /// <summary>
        /// <para>Authenticates by using local credential binding.</para>
        /// </summary>
        [NameInMap("satellite")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInputSatellite Satellite { get; set; }
        public class ConnectorAuthenticationInputSatellite : TeaModel {
            /// <summary>
            /// <para>Local credential binding name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private-gitlab</para>
            /// </summary>
            [NameInMap("bindingName")]
            [Validation(Required=false)]
            public string BindingName { get; set; }

        }

        /// <summary>
        /// <para>Authentication type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN_RESOURCE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
