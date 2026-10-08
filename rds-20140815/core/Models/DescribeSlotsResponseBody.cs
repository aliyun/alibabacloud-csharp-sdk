// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76AF0609-4195-5DFC-BC78-3AD76FF872BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of replication slots of the instance.</para>
        /// </summary>
        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<DescribeSlotsResponseBodySlots> Slots { get; set; }
        public class DescribeSlotsResponseBodySlots : TeaModel {
            /// <summary>
            /// <para>The name of the database in which the replication slot resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db_test01</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The plugin used by the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_decoding</para>
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// <para>The name of the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slot_test01</para>
            /// </summary>
            [NameInMap("SlotName")]
            [Validation(Required=false)]
            public string SlotName { get; set; }

            /// <summary>
            /// <para>The status of the replication slot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: Active.</description></item>
            /// <item><description>INACTIVE: Inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INACTIVE</para>
            /// </summary>
            [NameInMap("SlotStatus")]
            [Validation(Required=false)]
            public string SlotStatus { get; set; }

            /// <summary>
            /// <para>The type of the replication slot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>physical: Physical.</description></item>
            /// <item><description>logical: Logical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>logical</para>
            /// </summary>
            [NameInMap("SlotType")]
            [Validation(Required=false)]
            public string SlotType { get; set; }

            /// <summary>
            /// <para>The specific latency of the logical subscription on the subscriber corresponding to the current replication slot. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubReplayLag")]
            [Validation(Required=false)]
            public string SubReplayLag { get; set; }

            /// <summary>
            /// <para>Indicates whether the replication slot is temporary. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The replication slot is temporary.</description></item>
            /// <item><description>false: The replication slot is not temporary.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Temporary")]
            [Validation(Required=false)]
            public string Temporary { get; set; }

            /// <summary>
            /// <para>The amount of logs accumulated by the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16 MB</para>
            /// </summary>
            [NameInMap("WalDelay")]
            [Validation(Required=false)]
            public string WalDelay { get; set; }

        }

    }

}
