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
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public string DataCenter { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("SLSLogStore")]
                [Validation(Required=false)]
                public string SLSLogStore { get; set; }

                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public float? SamplingRate { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
