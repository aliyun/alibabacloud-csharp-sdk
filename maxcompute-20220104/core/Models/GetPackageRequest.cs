// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetPackageRequest : TeaModel {
        /// <summary>
        /// <para>The project to which the package belongs. This parameter is required if the package is installed in the MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>projectB</para>
        /// </summary>
        [NameInMap("sourceProject")]
        [Validation(Required=false)]
        public string SourceProject { get; set; }

    }

}
