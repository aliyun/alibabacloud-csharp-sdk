// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetCanTrySasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCanTrySasResponseBodyData Data { get; set; }
        public class GetCanTrySasResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetCanTrySasResponseBodyDataBody Body { get; set; }
            public class GetCanTrySasResponseBodyDataBody : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetCanTrySasResponseBodyDataBodyData Data { get; set; }
                public class GetCanTrySasResponseBodyDataBodyData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public int? CanTry { get; set; }

                    [NameInMap("CanTryVersions")]
                    [Validation(Required=false)]
                    public List<int?> CanTryVersions { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TryType")]
                    [Validation(Required=false)]
                    public int? TryType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0EBD97B8-65AD-52C8-94D5-A0F81E7D70D0</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6B48613E-86DE-5411-BDBE-429C80B45F3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
