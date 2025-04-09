// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateNumberDistrictInfoParsingTaskRequest : TeaModel {
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>190464</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

    }

}
