// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSupplementDagrunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DagrunList")]
        [Validation(Required=false)]
        public List<GetSupplementDagrunResponseBodyDagrunList> DagrunList { get; set; }
        public class GetSupplementDagrunResponseBodyDagrunList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-01</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1717081789000</para>
            /// </summary>
            [NameInMap("EndExecuteTime")]
            [Validation(Required=false)]
            public long? EndExecuteTime { get; set; }

            /// <summary>
            /// <para>Dagrun ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr_2242792_14542</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1717081729000</para>
            /// </summary>
            [NameInMap("StartExecuteTime")]
            [Validation(Required=false)]
            public long? StartExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f_8241792_20201202_2099680</para>
            /// </summary>
            [NameInMap("SupplementId")]
            [Validation(Required=false)]
            public string SupplementId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
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
