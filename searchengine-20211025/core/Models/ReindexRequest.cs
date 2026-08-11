// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ReindexRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp in seconds. This parameter is of the INT type. This parameter is required when the data source uses API push.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640867288</para>
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// <para>The OSS file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://opensearch</para>
        /// </summary>
        [NameInMap("ossDataPath")]
        [Validation(Required=false)]
        public string OssDataPath { get; set; }

        /// <summary>
        /// <para>The partition. This parameter is required when the data source is MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20220713</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

    }

}
