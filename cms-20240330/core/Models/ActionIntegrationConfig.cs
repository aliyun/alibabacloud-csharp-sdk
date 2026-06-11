// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ActionIntegrationConfig : TeaModel {
        /// <summary>
        /// <para>A list of actions to perform.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// <para>Indicates whether action integration is enabled.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
