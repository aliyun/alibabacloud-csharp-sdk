// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineWithAssetsCodeVersionShrinkRequest : TeaModel {
        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public long? BuildId { get; set; }

        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        [NameInMap("ConfOptions")]
        [Validation(Required=false)]
        public string ConfOptionsShrink { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
