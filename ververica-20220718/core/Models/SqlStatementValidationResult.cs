// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementValidationResult : TeaModel {
        /// <summary>
        /// <para>The error message of the verification result.</para>
        /// </summary>
        [NameInMap("errorDetails")]
        [Validation(Required=false)]
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// <para>The verification information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VALIDATION_RESULT_INVALID</para>
        /// </summary>
        [NameInMap("validationResult")]
        [Validation(Required=false)]
        public string ValidationResult { get; set; }

    }

}
