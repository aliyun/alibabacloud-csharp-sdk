// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetContextStoreAPIKeyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sk-abcd****</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-api-key</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
