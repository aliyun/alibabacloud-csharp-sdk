// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListIdentModelsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("PidIdentModelList")]
        [Validation(Required=true)]
        public List<ListIdentModelsResponsePidIdentModelList> PidIdentModelList { get; set; }
        public class ListIdentModelsResponsePidIdentModelList : TeaModel {
            [NameInMap("ModelId")]
            [Validation(Required=true)]
            public int? ModelId { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=true)]
            public string Desc { get; set; }

            [NameInMap("Model")]
            [Validation(Required=true)]
            public ListIdentModelsResponsePidIdentModelListModel Model { get; set; }
            public class ListIdentModelsResponsePidIdentModelListModel : TeaModel {
                [NameInMap("K")]
                [Validation(Required=true)]
                public float? K { get; set; }
                [NameInMap("Tau")]
                [Validation(Required=true)]
                public float? Tau { get; set; }
                [NameInMap("T1")]
                [Validation(Required=true)]
                public float? T1 { get; set; }
                [NameInMap("T2")]
                [Validation(Required=true)]
                public float? T2 { get; set; }
            };

        }

    }

}
