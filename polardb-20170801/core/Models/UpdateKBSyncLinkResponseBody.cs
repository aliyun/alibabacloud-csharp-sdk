// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKBSyncLinkResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pkbl-xxxxx</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EBEAA83D-1734-42E3-85E3-E25F6E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SyncSchedule")]
        [Validation(Required=false)]
        public string SyncSchedule { get; set; }

    }

}
