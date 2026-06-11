// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetIntegrationVersionForCSResponseBody : TeaModel {
        /// <summary>
        /// <para>The version of the Integration Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("integrationVersion")]
        [Validation(Required=false)]
        public string IntegrationVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD9BCF34-EA09-5643-BC11-AF41C8DFAE5A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
