// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTSpansRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Component")]
        [Validation(Required=false)]
        public string Component { get; set; }

        [NameInMap("CustomTags")]
        [Validation(Required=false)]
        public List<ListDSTSpansRequestCustomTags> CustomTags { get; set; }
        public class ListDSTSpansRequestCustomTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("LocalServiceName")]
        [Validation(Required=false)]
        public string LocalServiceName { get; set; }

        [NameInMap("MaxDuration")]
        [Validation(Required=false)]
        public long? MaxDuration { get; set; }

        [NameInMap("MiddlewareTags")]
        [Validation(Required=false)]
        public List<ListDSTSpansRequestMiddlewareTags> MiddlewareTags { get; set; }
        public class ListDSTSpansRequestMiddlewareTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RemoteServiceName")]
        [Validation(Required=false)]
        public string RemoteServiceName { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TestField1")]
        [Validation(Required=false)]
        public string TestField1 { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
