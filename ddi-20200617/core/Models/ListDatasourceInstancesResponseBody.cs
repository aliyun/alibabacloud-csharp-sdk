// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListDatasourceInstancesResponseBody : TeaModel {
        [NameInMap("DdiDatasourceInfoList")]
        [Validation(Required=false)]
        public ListDatasourceInstancesResponseBodyDdiDatasourceInfoList DdiDatasourceInfoList { get; set; }
        public class ListDatasourceInstancesResponseBodyDdiDatasourceInfoList : TeaModel {
            [NameInMap("DdiDatasourceInfo")]
            [Validation(Required=false)]
            public List<ListDatasourceInstancesResponseBodyDdiDatasourceInfoListDdiDatasourceInfo> DdiDatasourceInfo { get; set; }
            public class ListDatasourceInstancesResponseBodyDdiDatasourceInfoListDdiDatasourceInfo : TeaModel {
                public string ClusterId { get; set; }
                public long? CreateTime { get; set; }
                public string DatasourceId { get; set; }
                public string Descreption { get; set; }
                public long? ModifyTime { get; set; }
                public string Name { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public string VswitchId { get; set; }
                public ListDatasourceInstancesResponseBodyDdiDatasourceInfoListDdiDatasourceInfoPrivateAddressList PrivateAddressList { get; set; }
                public class ListDatasourceInstancesResponseBodyDdiDatasourceInfoListDdiDatasourceInfoPrivateAddressList : TeaModel {
                    [NameInMap("privateAddressList")]
                    [Validation(Required=false)]
                    public List<string> PrivateAddressList { get; set; }

                }
                public string SecurityGroupId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
