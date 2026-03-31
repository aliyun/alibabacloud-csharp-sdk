// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class DeleteProjectRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to logically delete the project. Valid values: true and false. Default value: true. The value false indicates that the project is physically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isLogical")]
        [Validation(Required=false)]
        public bool? IsLogical { get; set; }

    }

}
