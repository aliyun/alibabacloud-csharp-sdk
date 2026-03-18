// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class DeleteProjectRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a logical deletion. The default value is true. A value of false indicates a physical deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isLogical")]
        [Validation(Required=false)]
        public bool? IsLogical { get; set; }

    }

}
