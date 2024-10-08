// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceInstanceDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostics information.</para>
        /// </summary>
        [NameInMap("Diagnosis")]
        [Validation(Required=false)]
        public DescribeServiceInstanceDiagnosisResponseBodyDiagnosis Diagnosis { get; set; }
        public class DescribeServiceInstanceDiagnosisResponseBodyDiagnosis : TeaModel {
            /// <summary>
            /// <para>The solutions to the errors.</para>
            /// </summary>
            [NameInMap("Advices")]
            [Validation(Required=false)]
            public List<string> Advices { get; set; }

            /// <summary>
            /// <para>The causes of the errors.</para>
            /// </summary>
            [NameInMap("Causes")]
            [Validation(Required=false)]
            public List<string> Causes { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Container worker0 failed to pull image.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
