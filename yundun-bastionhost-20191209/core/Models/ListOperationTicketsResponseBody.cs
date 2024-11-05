// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationTicketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The O\&amp;M applications to be reviewed.</para>
        /// </summary>
        [NameInMap("OperationTickets")]
        [Validation(Required=false)]
        public List<ListOperationTicketsResponseBodyOperationTickets> OperationTickets { get; set; }
        public class ListOperationTicketsResponseBodyOperationTickets : TeaModel {
            /// <summary>
            /// <para>The ID of the O\&amp;M applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApplyUserId")]
            [Validation(Required=false)]
            public string ApplyUserId { get; set; }

            /// <summary>
            /// <para>The username of the O\&amp;M applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApplyUsername")]
            [Validation(Required=false)]
            public string ApplyUsername { get; set; }

            [NameInMap("ApproveComment")]
            [Validation(Required=false)]
            public string ApproveComment { get; set; }

            /// <summary>
            /// <para>The ID of the asset account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetAccountId")]
            [Validation(Required=false)]
            public string AssetAccountId { get; set; }

            /// <summary>
            /// <para>The username of the asset account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("AssetAccountName")]
            [Validation(Required=false)]
            public string AssetAccountName { get; set; }

            /// <summary>
            /// <para>The IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.167.XX.XX</para>
            /// </summary>
            [NameInMap("AssetAddress")]
            [Validation(Required=false)]
            public string AssetAddress { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poros-test</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The network domain ID of the asset.</para>
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
            /// <para>The name of the asset source to which the asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: an on-premises host.</description></item>
            /// <item><description><b>Ecs</b>: an Elastic Compute Service (ECS) instance.</description></item>
            /// <item><description><b>Rds</b>: an ApsaraDB RDS instance.</description></item>
            /// <item><description>A third-party asset source.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("AssetSource")]
            [Validation(Required=false)]
            public string AssetSource { get; set; }

            /// <summary>
            /// <para>The ID of the asset source to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSourceInstanceId")]
            [Validation(Required=false)]
            public string AssetSourceInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M application was submitted. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669965908</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("EffectCount")]
            [Validation(Required=false)]
            public int? EffectCount { get; set; }

            [NameInMap("EffectEndTime")]
            [Validation(Required=false)]
            public int? EffectEndTime { get; set; }

            [NameInMap("EffectStartTime")]
            [Validation(Required=false)]
            public int? EffectStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M application to be reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OperationTicketId")]
            [Validation(Required=false)]
            public string OperationTicketId { get; set; }

            /// <summary>
            /// <para>The O\&amp;M protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            /// <summary>
            /// <para>The status of the review. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Normal: to be reviewed</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of O\&amp;M applications to be reviewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
