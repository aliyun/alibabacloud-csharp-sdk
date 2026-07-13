// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListWorkersShrinkRequest : TeaModel {
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string GroupShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Mcp")]
        [Validation(Required=false)]
        public string Mcp { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("ModelProvider")]
        [Validation(Required=false)]
        public string ModelProvider { get; set; }

        [NameInMap("NameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
