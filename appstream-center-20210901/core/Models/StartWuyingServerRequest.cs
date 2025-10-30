// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class StartWuyingServerRequest : TeaModel {
        /// <summary>
        /// <para>The list of workstation IDs.</para>
        /// </summary>
        [NameInMap("WuyingServerIdList")]
        [Validation(Required=false)]
        public List<string> WuyingServerIdList { get; set; }

    }

}
