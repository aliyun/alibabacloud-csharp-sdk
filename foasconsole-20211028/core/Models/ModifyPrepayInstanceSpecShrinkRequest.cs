// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyPrepayInstanceSpecShrinkRequest : TeaModel {
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        [NameInMap("HaResourceSpec")]
        [Validation(Required=false)]
        public string HaResourceSpecShrink { get; set; }

        [NameInMap("HaVSwitchIds")]
        [Validation(Required=false)]
        public string HaVSwitchIdsShrink { get; set; }

        [NameInMap("HaZoneId")]
        [Validation(Required=false)]
        public string HaZoneId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public string ResourceSpecShrink { get; set; }

    }

}
