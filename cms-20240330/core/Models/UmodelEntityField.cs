// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UmodelEntityField : TeaModel {
        /// <summary>
        /// <para>The name of the entity field.</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The field alias or display value.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
