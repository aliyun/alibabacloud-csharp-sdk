// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleApiRequest : TeaModel {
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// regionId
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("SampleBatchType")]
        [Validation(Required=false)]
        public string SampleBatchType { get; set; }

        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceList { get; set; }

    }

}
