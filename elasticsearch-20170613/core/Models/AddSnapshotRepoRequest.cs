// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class AddSnapshotRepoRequest : TeaModel {
        /// <summary>
        /// <para>The cross-cluster backup information, which specifies the reference instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;repoPath&quot; :&quot;es-cn-4591jumei000u****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
