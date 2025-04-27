// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return information about data restoration of shards. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns information about data restoration of shards that are being restored.</description></item>
        /// <item><description>false: returns information about data restoration of all shards.</description></item>
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
