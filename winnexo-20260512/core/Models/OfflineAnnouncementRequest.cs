// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class OfflineAnnouncementRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the announcement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("announcementId")]
        [Validation(Required=false)]
        public long? AnnouncementId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. Pass it explicitly in winnexo-cli by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
