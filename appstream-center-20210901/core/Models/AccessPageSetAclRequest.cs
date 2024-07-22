// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AccessPageSetAclRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessPageId")]
        [Validation(Required=false)]
        public string AccessPageId { get; set; }

        [NameInMap("AccessPageName")]
        [Validation(Required=false)]
        public string AccessPageName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EffectTime")]
        [Validation(Required=false)]
        public int? EffectTime { get; set; }

        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
