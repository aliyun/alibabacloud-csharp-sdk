// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateEntityStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values: true: performs a dry run without making actual changes. false: sends a normal request. Default value: false.</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
