// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ActionIntegrationConfig : TeaModel {
        /// <summary>
        /// <para>The list of action integration IDs.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// <para>Indicates whether action integration is started.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
