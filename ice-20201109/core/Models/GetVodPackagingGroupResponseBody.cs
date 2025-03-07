// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVodPackagingGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the packaging group.</para>
        /// </summary>
        [NameInMap("PackagingGroup")]
        [Validation(Required=false)]
        public VodPackagingGroup PackagingGroup { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
