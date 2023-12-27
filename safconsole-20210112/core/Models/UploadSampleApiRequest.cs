// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20210112.Models
{
    public class UploadSampleApiRequest : TeaModel {
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        [NameInMap("SampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
