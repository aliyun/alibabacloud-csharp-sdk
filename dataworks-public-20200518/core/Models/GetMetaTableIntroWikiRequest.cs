// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableIntroWikiRequest : TeaModel {
        /// <summary>
        /// The GUID of the metatable.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The version of the instructions.
        /// </summary>
        [NameInMap("WikiVersion")]
        [Validation(Required=false)]
        public long? WikiVersion { get; set; }

    }

}
