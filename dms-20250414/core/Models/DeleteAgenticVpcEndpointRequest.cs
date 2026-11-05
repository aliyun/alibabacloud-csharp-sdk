// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DeleteAgenticVpcEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the endpoint to be deleted. You can delete the endpoint even if it has associated data sources, but this may interrupt access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-7xvra4ad6619266ba43d</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

    }

}
