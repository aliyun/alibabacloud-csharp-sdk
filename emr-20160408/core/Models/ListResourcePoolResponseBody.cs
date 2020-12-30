// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListResourcePoolResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PoolInfoList")]
        [Validation(Required=false)]
        public ListResourcePoolResponseBodyPoolInfoList PoolInfoList { get; set; }
        public class ListResourcePoolResponseBodyPoolInfoList : TeaModel {
            [NameInMap("PoolInfo")]
            [Validation(Required=false)]
            public List<ListResourcePoolResponseBodyPoolInfoListPoolInfo> PoolInfo { get; set; }
            public class ListResourcePoolResponseBodyPoolInfoListPoolInfo : TeaModel {
                [NameInMap("EcmResourcePoolConfig")]
                [Validation(Required=false)]
                public List<ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfig> EcmResourcePoolConfig { get; set; }
                public class ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfig : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ConfigType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                    [NameInMap("ConfigValue")]
                    [Validation(Required=false)]
                    public string ConfigValue { get; set; }

                    [NameInMap("Note")]
                    [Validation(Required=false)]
                    public string Note { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("ConfigKey")]
                    [Validation(Required=false)]
                    public string ConfigKey { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

            }
        };

    }

}
