// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class InstanceConfigDto : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>storage_root_path</para>
        /// </summary>
        [NameInMap("configKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BE</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("configValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ng-e24924dxxxxx</para>
        /// </summary>
        [NameInMap("nodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
