// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The application configurations.</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ListApplicationConfigsResponseBodyApplicationConfigs> ApplicationConfigs { get; set; }
        public class ListApplicationConfigsResponseBodyApplicationConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The status of the configuration value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EFFECT</para>
            /// </summary>
            [NameInMap("ConfigEffectState")]
            [Validation(Required=false)]
            public string ConfigEffectState { get; set; }

            /// <summary>
            /// <para>The name of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs-site.xml</para>
            /// </summary>
            [NameInMap("ConfigFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// <para>The key of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dfs.replication</para>
            /// </summary>
            [NameInMap("ConfigItemKey")]
            [Validation(Required=false)]
            public string ConfigItemKey { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ConfigItemValue")]
            [Validation(Required=false)]
            public string ConfigItemValue { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628589439114</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configurations are custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dfs.replication description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The initial value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InitValue")]
            [Validation(Required=false)]
            public string InitValue { get; set; }

            /// <summary>
            /// <para>The person who modified the configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170906468757****</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-d555335ced5****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp18y0ng3qqxog4mw****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628589439114</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The page number of the next page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
