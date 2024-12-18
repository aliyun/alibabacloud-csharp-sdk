// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("OperateAggregatorsResult")]
        [Validation(Required=false)]
        public DeleteAggregatorsResponseBodyOperateAggregatorsResult OperateAggregatorsResult { get; set; }
        public class DeleteAggregatorsResponseBodyOperateAggregatorsResult : TeaModel {
            /// <summary>
            /// <para>The details of the account group.</para>
            /// </summary>
            [NameInMap("OperateAggregators")]
            [Validation(Required=false)]
            public List<DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators> OperateAggregators { get; set; }
            public class DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators : TeaModel {
                /// <summary>
                /// <para>The ID of the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-dacf86d8314e00eb****</para>
                /// </summary>
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// <para>The error code returned.</para>
                /// <remarks>
                /// <para>No error code is returned for the account group if the account group is deleted.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>AccountNotExisted</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the request was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The request was successful.</description></item>
                /// <item><description>false: The request failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8195B664-9565-4685-89AC-8B5F04B44B92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
