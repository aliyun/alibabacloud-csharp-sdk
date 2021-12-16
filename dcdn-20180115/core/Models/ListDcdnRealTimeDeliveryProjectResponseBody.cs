// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnRealTimeDeliveryProjectResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListDcdnRealTimeDeliveryProjectResponseBodyContent Content { get; set; }
        public class ListDcdnRealTimeDeliveryProjectResponseBodyContent : TeaModel {
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects> Projects { get; set; }
            public class ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects : TeaModel {
                public string BusinessType { get; set; }
                public string DataCenter { get; set; }
                public string DomainName { get; set; }
                public string FieldName { get; set; }
                public string ProjectName { get; set; }
                public string SLSLogStore { get; set; }
                public string SLSProject { get; set; }
                public string SLSRegion { get; set; }
                public float? SamplingRate { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
