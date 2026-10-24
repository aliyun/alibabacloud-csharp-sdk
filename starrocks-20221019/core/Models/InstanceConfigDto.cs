// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class InstanceConfigDto : TeaModel {
        /// <summary>
        /// <para>The configuration item name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>storage_root_path</para>
        /// </summary>
        [NameInMap("configKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>The configuration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The configuration item value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("configValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The compute group ID, which is required only when the parameter is exclusive to the compute group. In other scenarios, leave it empty or set it to the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-e24924dxxxxx</para>
        /// </summary>
        [NameInMap("nodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
