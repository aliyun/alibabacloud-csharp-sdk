// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ReindexRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp in seconds. The value must be of the INTEGER type. This parameter is required if you specify an API data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640867288</para>
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// <para>oss data path</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://opensearch</para>
        /// </summary>
        [NameInMap("ossDataPath")]
        [Validation(Required=false)]
        public string OssDataPath { get; set; }

        /// <summary>
        /// <para>The partition in the MaxCompute table. This parameter is required if type is set to odps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20220713</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

    }

}
