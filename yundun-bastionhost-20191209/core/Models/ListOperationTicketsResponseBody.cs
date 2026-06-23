// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationTicketsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of O\&amp;M requests that are pending approval.</para>
        /// </summary>
        [NameInMap("OperationTickets")]
        [Validation(Required=false)]
        public List<ListOperationTicketsResponseBodyOperationTickets> OperationTickets { get; set; }
        public class ListOperationTicketsResponseBodyOperationTickets : TeaModel {
            /// <summary>
            /// <para>The ID of the user who submitted the O\&amp;M request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApplyUserId")]
            [Validation(Required=false)]
            public string ApplyUserId { get; set; }

            /// <summary>
            /// <para>The username of the user who submitted the O\&amp;M request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApplyUsername")]
            [Validation(Required=false)]
            public string ApplyUsername { get; set; }

            /// <summary>
            /// <para>The comments provided by the O\&amp;M engineer when submitting the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Request O&amp;M</para>
            /// </summary>
            [NameInMap("ApproveComment")]
            [Validation(Required=false)]
            public string ApproveComment { get; set; }

            /// <summary>
            /// <para>The ID of the asset account for which the O\&amp;M request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetAccountId")]
            [Validation(Required=false)]
            public string AssetAccountId { get; set; }

            /// <summary>
            /// <para>The logon name of the asset account for which the O\&amp;M request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("AssetAccountName")]
            [Validation(Required=false)]
            public string AssetAccountName { get; set; }

            /// <summary>
            /// <para>The address of the asset for which the O\&amp;M request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.167.XX.XX</para>
            /// </summary>
            [NameInMap("AssetAddress")]
            [Validation(Required=false)]
            public string AssetAddress { get; set; }

            /// <summary>
            /// <para>The ID of the asset for which the O\&amp;M request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The name of the asset for which the O\&amp;M request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poros-test</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The ID of the network domain to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssetNetworkDomainId")]
            [Validation(Required=false)]
            public string AssetNetworkDomainId { get; set; }

            /// <summary>
            /// <para>The operating system of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("AssetOs")]
            [Validation(Required=false)]
            public string AssetOs { get; set; }

            /// <summary>
            /// <para>The source of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Local</b>: a local host</para>
            /// </description></item>
            /// <item><description><para><b>Ecs</b>: an ECS instance</para>
            /// </description></item>
            /// <item><description><para><b>Rds</b>: an RDS instance</para>
            /// </description></item>
            /// <item><description><para>The name of a third-party asset source</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("AssetSource")]
            [Validation(Required=false)]
            public string AssetSource { get; set; }

            /// <summary>
            /// <para>The ID of the source of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSourceInstanceId")]
            [Validation(Required=false)]
            public string AssetSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the request was submitted. This is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669965908</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The number of permitted logons specified in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: unlimited logons. The O\&amp;M engineer can log on an unlimited number of times within the validity period.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: one-time logon. The O\&amp;M engineer can log on only once within the validity period.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EffectCount")]
            [Validation(Required=false)]
            public int? EffectCount { get; set; }

            /// <summary>
            /// <para>The end time of the O\&amp;M period specified by the O\&amp;M engineer. This is a UNIX timestamp. Unit: seconds.</para>
            /// <remarks>
            /// <para>A value of 0 indicates that the O\&amp;M engineer did not specify an end time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1679393152</para>
            /// </summary>
            [NameInMap("EffectEndTime")]
            [Validation(Required=false)]
            public int? EffectEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O\&amp;M period specified by the O\&amp;M engineer. This is a UNIX timestamp. Unit: seconds.</para>
            /// <remarks>
            /// <para>A value of 0 indicates that the O\&amp;M engineer did not specify a start time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1685600242</para>
            /// </summary>
            [NameInMap("EffectStartTime")]
            [Validation(Required=false)]
            public int? EffectStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M request that requires approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OperationTicketId")]
            [Validation(Required=false)]
            public string OperationTicketId { get; set; }

            /// <summary>
            /// <para>The name of the protocol used for the O\&amp;M request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            /// <summary>
            /// <para>The approval status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: pending approval</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of O\&amp;M requests that are pending approval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
