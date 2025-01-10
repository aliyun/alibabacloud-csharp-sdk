// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCustomQAV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FAFCD152-4791-5F2F-B0BE-2DC06FD4F05B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddCustomQAV2ResponseBodyResult Result { get; set; }
        public class AddCustomQAV2ResponseBodyResult : TeaModel {
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-10 10:01:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7***83</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("KeyWords")]
            [Validation(Required=false)]
            public string KeyWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8xxx9</para>
            /// </summary>
            [NameInMap("LastOperator")]
            [Validation(Required=false)]
            public string LastOperator { get; set; }

            [NameInMap("MajorQuestion")]
            [Validation(Required=false)]
            public string MajorQuestion { get; set; }

            /// <summary>
            /// <para>qaID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QaId")]
            [Validation(Required=false)]
            public string QaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SupplementaryQuestion")]
            [Validation(Required=false)]
            public string SupplementaryQuestion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-10 10:01:59</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
