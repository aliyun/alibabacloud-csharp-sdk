// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AddFaceVideoTemplateAdvanceRequest : TeaModel {
        [NameInMap("VideoScene")]
        [Validation(Required=false)]
        public string VideoScene { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public Stream VideoURLObject { get; set; }

    }

}
