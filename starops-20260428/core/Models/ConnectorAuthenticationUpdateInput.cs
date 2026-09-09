// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorAuthenticationUpdateInput : TeaModel {
        /// <summary>
        /// <para>The configuration that uses a username and password to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("basic")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputBasic Basic { get; set; }
        public class ConnectorAuthenticationUpdateInputBasic : TeaModel {
            /// <summary>
            /// <para>Replacement password</para>
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
        /// <para>The configuration that uses a bot token and signing key to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("botToken")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputBotToken BotToken { get; set; }
        public class ConnectorAuthenticationUpdateInputBotToken : TeaModel {
            /// <summary>
            /// <para>Replacement bot token</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bot-token</para>
            /// </summary>
            [NameInMap("botToken")]
            [Validation(Required=false)]
            public string BotToken { get; set; }

            /// <summary>
            /// <para>Replacement signing secret</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-signing-secret</para>
            /// </summary>
            [NameInMap("signingSecret")]
            [Validation(Required=false)]
            public string SigningSecret { get; set; }

        }

        /// <summary>
        /// <para>The configuration that uses an OAuth client identity to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("oauth")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputOauth Oauth { get; set; }
        public class ConnectorAuthenticationUpdateInputOauth : TeaModel {
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
            /// <para>Replacement OAuth client secret</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-client-secret</para>
            /// </summary>
            [NameInMap("clientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

        }

        /// <summary>
        /// <para>The configuration that uses a personal access token to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("patToken")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputPatToken PatToken { get; set; }
        public class ConnectorAuthenticationUpdateInputPatToken : TeaModel {
            /// <summary>
            /// <para>The personal access token used to replace the existing credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-personal-access-token</para>
            /// </summary>
            [NameInMap("patToken")]
            [Validation(Required=false)]
            public string PatToken { get; set; }

        }

        /// <summary>
        /// <para>The configuration that uses a RAM role ARN to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputRole Role { get; set; }
        public class ConnectorAuthenticationUpdateInputRole : TeaModel {
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
        /// <para>The configuration that uses a local credential binding to replace the existing authentication configuration.</para>
        /// </summary>
        [NameInMap("satellite")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInputSatellite Satellite { get; set; }
        public class ConnectorAuthenticationUpdateInputSatellite : TeaModel {
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
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
