// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateModelGroupRequest : TeaModel {
        /// <summary>
        /// <para>The full member array. An empty array clears all members.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[101, 102, 103]</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public List<long?> ModelList { get; set; }

        /// <summary>
        /// <para>The group name. This parameter performs a full overwrite. Pass the current name even if you do not want to rename the group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Professional Plan</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
