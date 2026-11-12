// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeReplicationSlotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of replication slots.</para>
        /// </summary>
        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<DescribeReplicationSlotsResponseBodySlots> Slots { get; set; }
        public class DescribeReplicationSlotsResponseBodySlots : TeaModel {
            /// <summary>
            /// <para>The ID of the PolarDB cluster to which the replication slot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-test123456</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The name of the database associated with the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDB</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The name of the output plugin used by the logical replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPlugin</para>
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// <para>The name of the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSlot</para>
            /// </summary>
            [NameInMap("SlotName")]
            [Validation(Required=false)]
            public string SlotName { get; set; }

            /// <summary>
            /// <para>The status of the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("SlotStatus")]
            [Validation(Required=false)]
            public string SlotStatus { get; set; }

            /// <summary>
            /// <para>The type of the replication slot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logical</para>
            /// </summary>
            [NameInMap("SlotType")]
            [Validation(Required=false)]
            public string SlotType { get; set; }

            /// <summary>
            /// <para>The name of the child node of the distributed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroup</para>
            /// </summary>
            [NameInMap("SubGroupName")]
            [Validation(Required=false)]
            public string SubGroupName { get; set; }

            /// <summary>
            /// <para>The replay lag of the subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SubReplayLag")]
            [Validation(Required=false)]
            public string SubReplayLag { get; set; }

            /// <summary>
            /// <para>Indicates whether the replication slot is temporary. The value is a string: true or false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Temporary")]
            [Validation(Required=false)]
            public string Temporary { get; set; }

            /// <summary>
            /// <para>The WAL latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("WalDelay")]
            [Validation(Required=false)]
            public string WalDelay { get; set; }

        }

    }

}
