// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class DeleteApiMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request. Generate this value on your client and make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. Use a universally unique identifier (UUID). The token is valid for three days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the API MCP service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
