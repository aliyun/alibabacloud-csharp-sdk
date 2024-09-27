// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud-native boxes.</para>
        /// </summary>
        [NameInMap("edge_machines")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachinesResponseBodyEdgeMachines> EdgeMachines { get; set; }
        public class DescribeEdgeMachinesResponseBodyEdgeMachines : TeaModel {
            /// <summary>
            /// <para>The time when the cloud-native box was activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-19T16:07:48+08:00</para>
            /// </summary>
            [NameInMap("active_time")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            /// <summary>
            /// <para>The time when the cloud-native box was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-07T20:44:00+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c61083909b13f4a95b8554bda9577****</para>
            /// </summary>
            [NameInMap("edge_machine_id")]
            [Validation(Required=false)]
            public string EdgeMachineId { get; set; }

            /// <summary>
            /// <para>The <c>hostname</c> of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-v-b010-ssdfw****</para>
            /// </summary>
            [NameInMap("hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The lifecycle of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>activated</para>
            /// </summary>
            [NameInMap("life_state")]
            [Validation(Required=false)]
            public string LifeState { get; set; }

            /// <summary>
            /// <para>The model of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACK-V-B010</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The machine name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-v-b010-ssdfw****</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the cloud-native box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("online_state")]
            [Validation(Required=false)]
            public string OnlineState { get; set; }

            /// <summary>
            /// <para>The serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACK9GBL31SXX****</para>
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>The time when the cloud-native box was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-07T20:44:00+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEdgeMachinesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEdgeMachinesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <para>Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
