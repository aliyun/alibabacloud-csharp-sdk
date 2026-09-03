// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateApiKeyStatusRequest : TeaModel {
        /// <summary>
        /// <para>The status of the API key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: The API key is valid.</description></item>
        /// <item><description>disabled: The API key is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
