// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RemoveScheduleMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The request body for removing scheduling monitoring.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RemoveCommand")]
        [Validation(Required=false)]
        public RemoveScheduleMonitorRequestRemoveCommand RemoveCommand { get; set; }
        public class RemoveScheduleMonitorRequestRemoveCommand : TeaModel {
            /// <summary>
            /// <para>The ID of the monitored item.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6912345678901234</para>
            /// </summary>
            [NameInMap("MonitoredItemId")]
            [Validation(Required=false)]
            public long? MonitoredItemId { get; set; }

            /// <summary>
            /// <para>The type of the monitored item. Valid values: LOGICAL_FIELD, OND_ID_NODE, SCHEDULE_PHYSICAL_NODE, MANUAL_PHYSICAL_NODE, ODM_NODE, LOGICAL_TABLE_NODE, and PROJECT.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCHEDULE_PHYSICAL_NODE</para>
            /// </summary>
            [NameInMap("MonitoredItemType")]
            [Validation(Required=false)]
            public string MonitoredItemType { get; set; }

        }

    }

}
