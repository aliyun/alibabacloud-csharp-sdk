// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAgentListResponseBody : TeaModel {
        [NameInMap("AgentList")]
        [Validation(Required=false)]
        public List<GetAgentListResponseBodyAgentList> AgentList { get; set; }
        public class GetAgentListResponseBodyAgentList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>rmagent_2ze68o4fden9o1s****</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("AgentOs")]
            [Validation(Required=false)]
            public string AgentOs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49046</para>
            /// </summary>
            [NameInMap("AgentPort")]
            [Validation(Required=false)]
            public string AgentPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public int? AgentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.2.5.3-1</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-2zel0147166****</para>
            /// </summary>
            [NameInMap("EcsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-09-29 11:05:22</para>
            /// </summary>
            [NameInMap("FirstLoginTime")]
            [Validation(Required=false)]
            public string FirstLoginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-09-29 15:50:22</para>
            /// </summary>
            [NameInMap("LastActiveTime")]
            [Validation(Required=false)]
            public string LastActiveTime { get; set; }

            [NameInMap("OsCpu")]
            [Validation(Required=false)]
            public int? OsCpu { get; set; }

            [NameInMap("OsMem")]
            [Validation(Required=false)]
            public int? OsMem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PktLoss")]
            [Validation(Required=false)]
            public int? PktLoss { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RmagentCpu")]
            [Validation(Required=false)]
            public int? RmagentCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RmagentMem")]
            [Validation(Required=false)]
            public int? RmagentMem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("SendByteCount")]
            [Validation(Required=false)]
            public long? SendByteCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SendBytes")]
            [Validation(Required=false)]
            public long? SendBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("SendPacketCount")]
            [Validation(Required=false)]
            public long? SendPacketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SendPackets")]
            [Validation(Required=false)]
            public long? SendPackets { get; set; }

            [NameInMap("SysConfig")]
            [Validation(Required=false)]
            public string SysConfig { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAgentListResponseBodyAgentListTags> Tags { get; set; }
            public class GetAgentListResponseBodyAgentListTags : TeaModel {
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v-asd2rrddgs****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
