// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyNodeConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>The number of data replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dataDuplicateNumber")]
        [Validation(Required=false)]
        public int? DataDuplicateNumber { get; set; }

        /// <summary>
        /// <para>The number of data shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dataFragmentNumber")]
        [Validation(Required=false)]
        public int? DataFragmentNumber { get; set; }

        /// <summary>
        /// <para>The traffic percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("flowRatio")]
        [Validation(Required=false)]
        public int? FlowRatio { get; set; }

        /// <summary>
        /// <para>The minimum service ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("minServicePercent")]
        [Validation(Required=false)]
        public int? MinServicePercent { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("published")]
        [Validation(Required=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_sh_domain_2</para>
        /// </summary>
        [NameInMap("clusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The name of the data source. Valid values: -search: search for data. -not_search: do not search for data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>search</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The name of the configuration before the modification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_qrs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>pop: a popularity model.</para>
        /// </description></item>
        /// <item><description><para>cp: a category prediction model.</para>
        /// </description></item>
        /// <item><description><para>hot: a top search model.</para>
        /// </description></item>
        /// <item><description><para>hint: a hint model.</para>
        /// </description></item>
        /// <item><description><para>suggest: a drop-down suggestions model.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hot</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
