// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Transform : TeaModel {
        /// <summary>
        /// <para>The target data type.</para>
        /// </summary>
        [NameInMap("castType")]
        [Validation(Required=false)]
        public FullDataType CastType { get; set; }

        /// <summary>
        /// <para>The field reference object.</para>
        /// </summary>
        [NameInMap("fieldRef")]
        [Validation(Required=false)]
        public FieldRef FieldRef { get; set; }

        /// <summary>
        /// <para>The input parameters.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<TransformInput> Inputs { get; set; }

        /// <summary>
        /// <para>The name of the transformation function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transform_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
