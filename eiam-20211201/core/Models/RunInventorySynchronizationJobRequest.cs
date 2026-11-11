// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class RunInventorySynchronizationJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization target.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sync_xxxxxx</para>
        /// </summary>
        [NameInMap("InventorySourceId")]
        [Validation(Required=false)]
        public string InventorySourceId { get; set; }

        /// <summary>
        /// <para>The resource types.</para>
        /// </summary>
        [NameInMap("InventoryTypes")]
        [Validation(Required=false)]
        public List<string> InventoryTypes { get; set; }

    }

}
