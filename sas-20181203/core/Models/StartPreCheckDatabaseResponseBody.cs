// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartPreCheckDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the database precheck task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0006d4pydyir6l1k****</para>
        /// </summary>
        [NameInMap("CreateMark")]
        [Validation(Required=false)]
        public string CreateMark { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6DC2DFF-AB3A-563A-8FC2-3D0D991E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
