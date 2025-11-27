// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetShutdownPolicyRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetShutdownPolicyRecordResponseBodyData> Data { get; set; }
        public class GetShutdownPolicyRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>noStop</para>
            /// </summary>
            [NameInMap("CurrentPolicy")]
            [Validation(Required=false)]
            public string CurrentPolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationPath")]
            [Validation(Required=false)]
            public string OperationPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>immediatelyStop</para>
            /// </summary>
            [NameInMap("PreviousPolicy")]
            [Validation(Required=false)]
            public string PreviousPolicy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210e876f16704666020714468dab35</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
