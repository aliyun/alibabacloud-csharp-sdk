// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class ListInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListInstancesResponseData Data { get; set; }
        public class ListInstancesResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long? Count { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public List<ListInstancesResponseDataList> List { get; set; }
            public class ListInstancesResponseDataList : TeaModel {
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public int? InstanceStatus { get; set; }
                public long? CreateTime { get; set; }
                public string ExpiredTime { get; set; }
                public List<ListInstancesResponseDataListTags> Tags { get; set; }
                public class ListInstancesResponseDataListTags : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
