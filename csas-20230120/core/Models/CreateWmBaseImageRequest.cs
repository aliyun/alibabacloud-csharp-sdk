// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Opacity")]
        [Validation(Required=false)]
        public int? Opacity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
