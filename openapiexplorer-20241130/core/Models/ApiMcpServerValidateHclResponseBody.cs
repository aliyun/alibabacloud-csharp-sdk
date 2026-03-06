// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ApiMcpServerValidateHclResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic report of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Argument or block definition required: An argument or block definition is required here.</para>
        /// </summary>
        [NameInMap("diagnosticReport")]
        [Validation(Required=false)]
        public object DiagnosticReport { get; set; }

        /// <summary>
        /// <para>The list of error messages.</para>
        /// </summary>
        [NameInMap("errors")]
        [Validation(Required=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Terraform HCL code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0628e13692023222bef9d6377dd03da3304b689e1b2df60f584ea27b4163bf07</para>
        /// </summary>
        [NameInMap("hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

        /// <summary>
        /// <para>Indicates whether the code is valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isValid")]
        [Validation(Required=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// <para>The list of parameters.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of warning messages.</para>
        /// </summary>
        [NameInMap("warnings")]
        [Validation(Required=false)]
        public List<string> Warnings { get; set; }

    }

}
