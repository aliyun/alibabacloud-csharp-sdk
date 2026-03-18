// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GenerateCLICommandResponseBody : TeaModel {
        /// <summary>
        /// <para>CLI command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun ecs DescribeRegions --ResourceType instance</para>
        /// </summary>
        [NameInMap("cli")]
        [Validation(Required=false)]
        public string Cli { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A707AFA8-1A4C-5B2A-A165-8436C1EA38DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("unifiedCli")]
        [Validation(Required=false)]
        public string UnifiedCli { get; set; }

    }

}
