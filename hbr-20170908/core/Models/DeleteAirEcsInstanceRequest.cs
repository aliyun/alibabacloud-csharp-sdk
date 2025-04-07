// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteAirEcsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Elastic Compute Service (ECS) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6ir9y******hvisj</para>
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// <para>The data sources for which the client needs to be uninstalled.</para>
        /// </summary>
        [NameInMap("UninstallClientSourceTypes")]
        [Validation(Required=false)]
        public List<string> UninstallClientSourceTypes { get; set; }

    }

}
