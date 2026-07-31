// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateModelGroupRequest : TeaModel {
        /// <summary>
        /// <para>The array of model IDs. At least one element is required. Each element must be the numeric model ID, not the model identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[101, 102, 103]</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public List<long?> ModelList { get; set; }

        /// <summary>
        /// <para>The group name. The name must be 1 to 50 characters in length and must be unique within the tenant (case-insensitive).</para>
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
