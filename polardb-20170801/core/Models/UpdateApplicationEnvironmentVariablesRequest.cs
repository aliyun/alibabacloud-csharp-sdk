// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateApplicationEnvironmentVariablesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after the update. The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>A mapping from environment variable names to values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ENV_TEST&quot;: &quot;test-value&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
