// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SmartCluster : TeaModel {
        /// <summary>
        /// <para>The category of the grouping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>figure</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The time when the grouping was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The description of the grouping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个智能分组的描述示例，它用于展示记录的格式。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The grouping name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySmartCluster1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The intelligent grouping ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SmartCluster-12cd1645-deae-4b5e-9434-613747b75f6d</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The status of the grouping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("ObjectStatus")]
        [Validation(Required=false)]
        public string ObjectStatus { get; set; }

        /// <summary>
        /// <para>The grouping type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smart-cluster</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1023210024677934</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyProject</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The reason why the grouping failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[InvalidArgument.BaseURIs] Each BaseURI must contain exactly one figure</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The grouping rule. This parameter is deprecated. Use the Rules parameter instead.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public SmartClusterRule Rule { get; set; }

        /// <summary>
        /// <para>The list of grouping rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<SmartClusterRule> Rules { get; set; }

        /// <summary>
        /// <para>The time when the grouping was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
