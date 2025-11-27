// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetIntegrationVersionForCSResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("integrationVersion")]
        [Validation(Required=false)]
        public string IntegrationVersion { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD9BCF34-EA09-5643-BC11-AF41C8DFAE5A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
