// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class CreateComputeTask2Request : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        [NameInMap("dataSetIds")]
        [Validation(Required=false)]
        public string DataSetIds { get; set; }

        [NameInMap("morseInfoList")]
        [Validation(Required=false)]
        public List<CreateComputeTask2RequestMorseInfoList> MorseInfoList { get; set; }
        public class CreateComputeTask2RequestMorseInfoList : TeaModel {
            [NameInMap("cuId")]
            [Validation(Required=false)]
            public string CuId { get; set; }

            [NameInMap("cuVersion")]
            [Validation(Required=false)]
            public string CuVersion { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        [NameInMap("taskSource")]
        [Validation(Required=false)]
        public string TaskSource { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
