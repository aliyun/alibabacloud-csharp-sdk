// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeUserQuotaApplicationsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("UserQuotaApplications")]
        [Validation(Required=false)]
        public DescribeUserQuotaApplicationsResponseBodyUserQuotaApplications UserQuotaApplications { get; set; }
        public class DescribeUserQuotaApplicationsResponseBodyUserQuotaApplications : TeaModel {
            [NameInMap("UserQuotaApplication")]
            [Validation(Required=false)]
            public List<DescribeUserQuotaApplicationsResponseBodyUserQuotaApplicationsUserQuotaApplication> UserQuotaApplication { get; set; }
            public class DescribeUserQuotaApplicationsResponseBodyUserQuotaApplicationsUserQuotaApplication : TeaModel {
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                [NameInMap("QuotaValue")]
                [Validation(Required=false)]
                public long? QuotaValue { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
