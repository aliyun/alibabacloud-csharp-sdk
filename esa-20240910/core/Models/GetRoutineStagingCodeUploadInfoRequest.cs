// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineStagingCodeUploadInfoRequest : TeaModel {
        /// <summary>
        /// <para>The code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the description of code</para>
        /// </summary>
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <para>The routine name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetRoutineStagingCodeUploadInfo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
