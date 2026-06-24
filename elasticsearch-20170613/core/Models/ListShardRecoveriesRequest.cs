// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display shard data recovery tracking information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Displays only ongoing shard data recovery tracking information.</para>
        /// </description></item>
        /// <item><description><para>false: Displays all shard data recovery tracking information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("activeOnly")]
        [Validation(Required=false)]
        public bool? ActiveOnly { get; set; }

    }

}
