// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorAuthentication : TeaModel {
        /// <summary>
        /// <para>The security identity information for basic authentication, excluding the password.</para>
        /// </summary>
        [NameInMap("basic")]
        [Validation(Required=false)]
        public ConnectorAuthenticationBasic Basic { get; set; }
        public class ConnectorAuthenticationBasic : TeaModel {
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
        /// <para>The security identity information for the bot, excluding the token and signing key.</para>
        /// </summary>
        [NameInMap("botToken")]
        [Validation(Required=false)]
        public ConnectorAuthenticationBotToken BotToken { get; set; }
        public class ConnectorAuthenticationBotToken : TeaModel {
            /// <summary>
            /// <para>Bot ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bot-123456</para>
            /// </summary>
            [NameInMap("botId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

        }

        /// <summary>
        /// <para>The security identity information for OAuth, excluding the client secret.</para>
        /// </summary>
        [NameInMap("oauth")]
        [Validation(Required=false)]
        public ConnectorAuthenticationOauth Oauth { get; set; }
        public class ConnectorAuthenticationOauth : TeaModel {
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

        }

        /// <summary>
        /// <para>The security identity information based on the RAM role ARN.</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public ConnectorAuthenticationRole Role { get; set; }
        public class ConnectorAuthenticationRole : TeaModel {
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
        /// <para>The security identity information based on local credential binding.</para>
        /// </summary>
        [NameInMap("satellite")]
        [Validation(Required=false)]
        public ConnectorAuthenticationSatellite Satellite { get; set; }
        public class ConnectorAuthenticationSatellite : TeaModel {
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
