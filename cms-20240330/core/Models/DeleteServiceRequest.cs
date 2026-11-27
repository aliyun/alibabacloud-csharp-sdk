// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without making actual changes.</description></item>
        /// <item><description>false: Sends a normal request.
        /// Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
