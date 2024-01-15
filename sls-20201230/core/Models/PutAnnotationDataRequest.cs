// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutAnnotationDataRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the data.
        /// </summary>
        [NameInMap("annotationdataId")]
        [Validation(Required=false)]
        public string AnnotationdataId { get; set; }

        /// <summary>
        /// The data structure of the request.
        /// </summary>
        [NameInMap("mlDataParam")]
        [Validation(Required=false)]
        public MLDataParam MlDataParam { get; set; }

        /// <summary>
        /// The raw log data.
        /// </summary>
        [NameInMap("rawLog")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> RawLog { get; set; }

    }

}
