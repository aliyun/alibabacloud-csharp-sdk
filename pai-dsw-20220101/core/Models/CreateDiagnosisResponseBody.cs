// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Resource.InsufficientResource</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Insufficient resource</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Switch resource config</para>
        /// </summary>
        [NameInMap("SolutionMessage")]
        [Validation(Required=false)]
        public string SolutionMessage { get; set; }

    }

}
