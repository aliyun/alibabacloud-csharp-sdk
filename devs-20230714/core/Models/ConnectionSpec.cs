// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ConnectionSpec : TeaModel {
        [NameInMap("account")]
        [Validation(Required=false)]
        public GitAccount Account { get; set; }

        [NameInMap("gitlabConfig")]
        [Validation(Required=false)]
        public GitLabConfig GitlabConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>github</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
