// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateChunkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>You must provide the chunkToken and at least one of the content or enabled parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>Required when modifying the content. Used for idempotent retries of asynchronous edits. This parameter is not used as a query parameter for GetAsset. If the same token is used with different parameters, IdempotencyConflict is returned. This parameter can be omitted when only modifying the enabled status, and no asynchronous receipt is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chunk-update-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
