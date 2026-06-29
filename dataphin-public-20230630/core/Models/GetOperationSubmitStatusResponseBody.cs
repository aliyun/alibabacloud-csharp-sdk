// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetOperationSubmitStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The submit status of the operation.</para>
        /// </summary>
        [NameInMap("OperationSubmitJob")]
        [Validation(Required=false)]
        public GetOperationSubmitStatusResponseBodyOperationSubmitJob OperationSubmitJob { get; set; }
        public class GetOperationSubmitStatusResponseBodyOperationSubmitJob : TeaModel {
            /// <summary>
            /// <para>The business ID. If the operation is a data backfill, this value is the data backfill workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f_122_232342</para>
            /// </summary>
            [NameInMap("ExternalBizId")]
            [Validation(Required=false)]
            public string ExternalBizId { get; set; }

            /// <summary>
            /// <para>The submit ID of the data backfill request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUPPLY_DATA: data backfill.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUPPLY_DATA</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("OperationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The user ID of the submitter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132344</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
