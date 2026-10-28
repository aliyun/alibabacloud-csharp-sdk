// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetShutdownPolicyRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the customer was created. If the value is true, the Message contains the CID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetShutdownPolicyRecordResponseBodyData> Data { get; set; }
        public class GetShutdownPolicyRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>immediatelyStop: immediate shutdown upon overdue payment.</description></item>
            /// <item><description>delayStop: deferred shutdown quota applied.</description></item>
            /// <item><description>noStop: no shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.CurrentPolicy.enum.immediatelyStop ]Immediate shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.CurrentPolicy.enum.noStop ]No shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.CurrentPolicy.enum.delayStop ]Deferred shutdown quota applied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>noStop</para>
            /// </summary>
            [NameInMap("CurrentPolicy")]
            [Validation(Required=false)]
            public string CurrentPolicy { get; set; }

            /// <summary>
            /// <para>The method by which the operation was initiated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>API: API.</description></item>
            /// <item><description>ACPN: ACPN.</description></item>
            /// <item><description>ALIYUN_BIZ: Alibaba Cloud internal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationPath")]
            [Validation(Required=false)]
            public string OperationPath { get; set; }

            /// <summary>
            /// <para>The operation time (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The policy before the change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>immediatelyStop: immediate shutdown upon overdue payment.</description></item>
            /// <item><description>delayStop: deferred shutdown quota applied.</description></item>
            /// <item><description>noStop: no shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.PreviousPolicy.enum.immediatelyStop ]Immediate shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.PreviousPolicy.enum.noStop ]No shutdown upon overdue payment.
            /// [_single.resp.200.props.Data.items.PreviousPolicy.enum.delayStop ]Deferred shutdown quota applied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>immediatelyStop</para>
            /// </summary>
            [NameInMap("PreviousPolicy")]
            [Validation(Required=false)]
            public string PreviousPolicy { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e876f16704666020714468dab35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
