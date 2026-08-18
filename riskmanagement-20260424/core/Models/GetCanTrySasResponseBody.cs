// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetCanTrySasResponseBody : TeaModel {
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
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCanTrySasResponseBodyData Data { get; set; }
        public class GetCanTrySasResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetCanTrySasResponseBodyDataBody Body { get; set; }
            public class GetCanTrySasResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <para>The data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetCanTrySasResponseBodyDataBodyData Data { get; set; }
                public class GetCanTrySasResponseBodyDataBodyData : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the user is eligible for a free trial. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: Eligible.</description></item>
                    /// <item><description><b>0</b>: Not eligible.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public int? CanTry { get; set; }

                    /// <summary>
                    /// <para>The list of editions available for trial.</para>
                    /// </summary>
                    [NameInMap("CanTryVersions")]
                    [Validation(Required=false)]
                    public List<int?> CanTryVersions { get; set; }

                    /// <summary>
                    /// <para>The trial type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: Trial is not allowed.</description></item>
                    /// <item><description><b>1</b>: First trial.</description></item>
                    /// <item><description><b>2</b>: Second trial.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TryType")]
                    [Validation(Required=false)]
                    public int? TryType { get; set; }

                }

                /// <summary>
                /// <para>Id of the request</para>
                /// 
                /// <b>Example:</b>
                /// <para>0EBD97B8-65AD-52C8-94D5-A0F81E7D70D0</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

        }

        /// <summary>
        /// <para>The message. The value is the same as the Code parameter value.</para>
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
        /// <para>6B48613E-86DE-5411-BDBE-429C80B45F3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call is successful. This does not indicate whether subsequent business operations are successful.</para>
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
