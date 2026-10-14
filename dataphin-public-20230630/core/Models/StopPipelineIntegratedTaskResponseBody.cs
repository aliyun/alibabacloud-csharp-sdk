// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class StopPipelineIntegratedTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The batch results of stopping integrated incremental and full instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopPipelineIntegratedTaskResponseBodyData Data { get; set; }
        public class StopPipelineIntegratedTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The stop results for each instance.</para>
            /// </summary>
            [NameInMap("DevOpsActionResDTOList")]
            [Validation(Required=false)]
            public List<StopPipelineIntegratedTaskResponseBodyDataDevOpsActionResDTOList> DevOpsActionResDTOList { get; set; }
            public class StopPipelineIntegratedTaskResponseBodyDataDevOpsActionResDTOList : TeaModel {
                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eedsauto</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The job owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1692173406264688</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The operation status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAIED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The number of failed stops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public long? Fail { get; set; }

            /// <summary>
            /// <para>The number of successful stops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public long? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
