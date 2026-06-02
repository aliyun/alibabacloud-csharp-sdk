// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class UpdateUserAuthConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;apiKey\&quot;: \&quot;************\&quot;}</para>
        /// </summary>
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uac-42b60d53bcce466d9d08</para>
        /// </summary>
        [NameInMap("AuthConfigId")]
        [Validation(Required=false)]
        public string AuthConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("AuthConfigName")]
        [Validation(Required=false)]
        public string AuthConfigName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-6b8df2297dca4a5f8f15</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectorVersion")]
        [Validation(Required=false)]
        public string ConnectorVersion { get; set; }

    }

}
