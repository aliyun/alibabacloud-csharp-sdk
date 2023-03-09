// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyDataList DataList { get; set; }
        public class GetInstanceListResponseBodyDataList : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyDataListData> Data { get; set; }
            public class GetInstanceListResponseBodyDataListData : TeaModel {
                [NameInMap("AliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
