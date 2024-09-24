// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartDiscoverDatabaseTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48bced6d-2aee-4fa2-9aba-b846b77b****</para>
        /// </summary>
        [NameInMap("CreateMark")]
        [Validation(Required=false)]
        public string CreateMark { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F46921AF-CC55-5971-92C9-7E09E160****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
