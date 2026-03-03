// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class GetLastDeploymentConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
