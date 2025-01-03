// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineJobsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListPipelineJobsResponseBodyJobs> Jobs { get; set; }
        public class ListPipelineJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ss_saxsxsxs</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("lastJobId")]
            [Validation(Required=false)]
            public long? LastJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("lastJobParams")]
            [Validation(Required=false)]
            public string LastJobParams { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true 接口调用成功，false 接口调用失败</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
