// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CreateDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("AccessLevel")]
        [Validation(Required=false)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// <para>The dataset search configuration.</para>
        /// </summary>
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public string DatasetConfigShrink { get; set; }

        /// <summary>
        /// <para>The description of the dataset. This is the display name in the console. Use a human-readable name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业知识库</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>The name of the dataset. The name must be globally unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>businessDataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CustomSemanticSearch: A custom semantic index. This is the default value. Upload documents to build the dataset.</para>
        /// </description></item>
        /// <item><description><para>ThirdSearch: A third-party search source (API). Configure your own search API.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CustomSemanticSearch</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>Dataset index configuration.</para>
        /// </summary>
        [NameInMap("DocumentHandleConfig")]
        [Validation(Required=false)]
        public string DocumentHandleConfigShrink { get; set; }

        /// <summary>
        /// <para>The invocation method. Currently, only portal is supported, which indicates an invocation from the console.</para>
        /// <list type="bullet">
        /// <item><description><para>If left empty: When DatasetType is ThirdSearch, datasetConfig.SearchSourceConfigs (third-party API definition) is required.</para>
        /// </description></item>
        /// <item><description><para>If set to portal: When DatasetType is ThirdSearch, the system initializes a SearchSourceConfigs (third-party API demo) example by default for your reference.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>portal</para>
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// <para>The dataset search switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Disabled for all.</para>
        /// </description></item>
        /// <item><description><para>1: Visible only to Miao Search.</para>
        /// </description></item>
        /// <item><description><para>2: Visible only to Miao Bi.</para>
        /// </description></item>
        /// <item><description><para>3: Visible to both Miao Search and Miao Bi. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SearchDatasetEnable")]
        [Validation(Required=false)]
        public int? SearchDatasetEnable { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
