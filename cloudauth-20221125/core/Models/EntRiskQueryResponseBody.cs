// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EntRiskQueryResponseBodyResult Result { get; set; }
        public class EntRiskQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<EntRiskQueryResponseBodyResultRiskList> RiskList { get; set; }
            public class EntRiskQueryResponseBodyResultRiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>92500112MA5UHU****</para>
                /// </summary>
                [NameInMap("CreditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("EntName")]
                [Validation(Required=false)]
                public string EntName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-02-03</para>
                /// </summary>
                [NameInMap("ListedDate")]
                [Validation(Required=false)]
                public string ListedDate { get; set; }

                [NameInMap("ListedReason")]
                [Validation(Required=false)]
                public string ListedReason { get; set; }

                [NameInMap("OperationOrg")]
                [Validation(Required=false)]
                public string OperationOrg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50011260996****</para>
                /// </summary>
                [NameInMap("RegNo")]
                [Validation(Required=false)]
                public string RegNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-02-06</para>
                /// </summary>
                [NameInMap("RemovedDate")]
                [Validation(Required=false)]
                public string RemovedDate { get; set; }

                [NameInMap("RemovedOrg")]
                [Validation(Required=false)]
                public string RemovedOrg { get; set; }

                [NameInMap("RemovedReason")]
                [Validation(Required=false)]
                public string RemovedReason { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
