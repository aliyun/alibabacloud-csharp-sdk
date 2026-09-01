// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeBaseFileShardingStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e347ddb8-49bb-5c66-94bc-fa05cedaeac8</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InheritSpaceStrategy")]
        [Validation(Required=false)]
        public bool? InheritSpaceStrategy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-2zesv6l6a63xsrym</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public string ShardingStrategyConfigShrink { get; set; }

    }

}
