// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOfflineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The reindexing method. Valid values: api: API data source. indexRecover: data recovery by using indexing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>indexRecover</para>
        /// </summary>
        [NameInMap("buildMode")]
        [Validation(Required=false)]
        public string BuildMode { get; set; }

        /// <summary>
        /// <para>The configuration name, which is stored as a key.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Config { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values: odps: MaxCompute. swift: Swift. unKnow: unknown type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxComputer</para>
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required when index building by using API data sources is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640867288</para>
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// <para>The data center in which the data source is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160142641</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// <para>This parameter is required when index building for full data in a MaxCompute data source is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20211202</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The push mode of the configuration. By default, only the configuration is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUSH_ONLY</para>
        /// </summary>
        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

    }

}
