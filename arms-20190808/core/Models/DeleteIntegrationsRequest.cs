// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteIntegrationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("IntegrationId")]
        [Validation(Required=false)]
        public long? IntegrationId { get; set; }

    }

}
