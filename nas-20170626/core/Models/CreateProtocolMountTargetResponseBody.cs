// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateProtocolMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the export directory for the protocol service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-123****</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public string ExportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
