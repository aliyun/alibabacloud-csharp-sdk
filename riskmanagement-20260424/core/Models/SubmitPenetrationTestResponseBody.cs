// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class SubmitPenetrationTestResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitPenetrationTestResponseBodyData Data { get; set; }
        public class SubmitPenetrationTestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<SubmitPenetrationTestResponseBodyDataList> List { get; set; }
            public class SubmitPenetrationTestResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The type of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EIP</b>: The public IP address of a virtual private cloud (VPC).</description></item>
                /// <item><description><b>SLB</b>: load balancing.</description></item>
                /// <item><description><b>ECS</b>: The public IP address of an Elastic Compute Service (ECS) instance in the classic network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.xxx.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67BD8435-6624-5484-A75D-170231B51615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The call status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
