// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class ListScenesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=true)]
        public string ErrMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListScenesResponseData> Data { get; set; }
        public class ListScenesResponseData : TeaModel {
            [NameInMap("SceneId")]
            [Validation(Required=true)]
            public string SceneId { get; set; }

        }

    }

}
