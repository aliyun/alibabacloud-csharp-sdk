// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UploadSampleApiRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
