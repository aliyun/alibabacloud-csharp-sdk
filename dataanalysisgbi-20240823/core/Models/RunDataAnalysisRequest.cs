// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class RunDataAnalysisRequest : TeaModel {
        [NameInMap("agentCtrlParams")]
        [Validation(Required=false)]
        public object AgentCtrlParams { get; set; }

        [NameInMap("dataRole")]
        [Validation(Required=false)]
        public List<string> DataRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("generateSqlOnly")]
        [Validation(Required=false)]
        public bool? GenerateSqlOnly { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sessionID</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STANDARD_MIX</para>
        /// </summary>
        [NameInMap("specificationType")]
        [Validation(Required=false)]
        public string SpecificationType { get; set; }

        [NameInMap("userParams")]
        [Validation(Required=false)]
        public object UserParams { get; set; }

    }

}
