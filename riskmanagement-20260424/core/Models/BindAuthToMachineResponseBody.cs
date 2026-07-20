// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class BindAuthToMachineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindAuthToMachineResponseBodyData Data { get; set; }
        public class BindAuthToMachineResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public BindAuthToMachineResponseBodyDataBody Body { get; set; }
            public class BindAuthToMachineResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public int? BindCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InsufficientCoreCount")]
                [Validation(Required=false)]
                public int? InsufficientCoreCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InsufficientEcsCount")]
                [Validation(Required=false)]
                public int? InsufficientEcsCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>F799C1E4-D4C6-5964-A6D1-4BA9CCF105F2</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnBindCount")]
                [Validation(Required=false)]
                public int? UnBindCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEE90F8C-EDC2-5394-953B-D07A121612B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
