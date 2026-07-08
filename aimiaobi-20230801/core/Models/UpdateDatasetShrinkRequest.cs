// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("AccessLevel")]
        [Validation(Required=false)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// <para>The configurations for a third-party search dataset.</para>
        /// </summary>
        [NameInMap("DatasetConfig")]
        [Validation(Required=false)]
        public string DatasetConfigShrink { get; set; }

        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业自定义数据集</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable search for the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SearchDatasetEnable")]
        [Validation(Required=false)]
        public int? SearchDatasetEnable { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="">Get a workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
