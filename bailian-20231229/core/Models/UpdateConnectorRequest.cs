// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The name of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-connector</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <para>A description of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>never_delete_aeip_95_us-west-1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
