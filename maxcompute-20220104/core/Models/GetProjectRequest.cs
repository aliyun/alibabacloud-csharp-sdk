// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetProjectRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withQuotaProductType")]
        [Validation(Required=false)]
        public bool? WithQuotaProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withStorageTierInfo")]
        [Validation(Required=false)]
        public bool? WithStorageTierInfo { get; set; }

    }

}
