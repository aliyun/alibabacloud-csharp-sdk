// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EraseVideoLogoRequest : TeaModel {
        [NameInMap("Boxes")]
        [Validation(Required=false)]
        public List<EraseVideoLogoRequestBoxes> Boxes { get; set; }
        public class EraseVideoLogoRequestBoxes : TeaModel {
            [NameInMap("H")]
            [Validation(Required=false)]
            public float? H { get; set; }

            [NameInMap("W")]
            [Validation(Required=false)]
            public float? W { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
