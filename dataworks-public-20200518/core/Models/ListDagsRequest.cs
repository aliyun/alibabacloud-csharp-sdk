// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsRequest : TeaModel {
        /// <summary>
        /// The sequence number that uniquely identifies the data backfill operation. You can call the [GetDag](~~189753~~) operation to obtain the sequence number.
        /// </summary>
        [NameInMap("OpSeq")]
        [Validation(Required=false)]
        public long? OpSeq { get; set; }

        /// <summary>
        /// The environment of the workspace. Valid values: PROD and DEV. PROD indicates the production environment. DEV indicates the development environment.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
