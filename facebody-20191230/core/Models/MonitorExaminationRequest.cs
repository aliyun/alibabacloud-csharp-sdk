// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MonitorExaminationRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
