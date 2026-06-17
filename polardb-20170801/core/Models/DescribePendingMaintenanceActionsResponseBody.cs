// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePendingMaintenanceActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>314127C2-B6C1-4F58-B1F6-E6B645******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of pending events.</para>
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<DescribePendingMaintenanceActionsResponseBodyTypeList> TypeList { get; set; }
        public class DescribePendingMaintenanceActionsResponseBodyTypeList : TeaModel {
            /// <summary>
            /// <para>The number of pending events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The task type of the pending event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DatabaseSoftwareUpgrading</b>: database software upgrade</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseHardwareMaintenance</b>: hardware maintenance and upgrade</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseStorageUpgrading</b>: database storage upgrade</para>
            /// </description></item>
            /// <item><description><para><b>DatabaseProxyUpgrading</b>: proxy minor version upgrade</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DatabaseSoftwareUpgrading</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
