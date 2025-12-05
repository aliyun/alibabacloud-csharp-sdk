// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretRequest : TeaModel {
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public UpdateSecretRequestExtendedConfig ExtendedConfig { get; set; }
        public class UpdateSecretRequestExtendedConfig : TeaModel {
            /// <summary>
            /// <para>The custom data in the extended configuration of the secret.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is specified, the existing extended configuration of the secret is updated.</description></item>
            /// <item><description>This parameter is unavailable for generic secrets.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DBName&quot;:&quot;app1&quot;,&quot;Port&quot;:&quot;3306&quot;}</para>
            /// </summary>
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomData { get; set; }

        }

        /// <summary>
        /// <para>The description of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datainfo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
