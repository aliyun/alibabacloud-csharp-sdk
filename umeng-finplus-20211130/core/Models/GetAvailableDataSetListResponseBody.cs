// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class GetAvailableDataSetListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAvailableDataSetListResponseBodyData> Data { get; set; }
        public class GetAvailableDataSetListResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dataSetType")]
            [Validation(Required=false)]
            public int? DataSetType { get; set; }

            [NameInMap("datasetId")]
            [Validation(Required=false)]
            public long? DatasetId { get; set; }

            [NameInMap("idTypeDesc")]
            [Validation(Required=false)]
            public string IdTypeDesc { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("statusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
