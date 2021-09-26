// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsInstanceDimResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataLimitsInstanceDimResponseBodyItems> Items { get; set; }
        public class DescribeDataLimitsInstanceDimResponseBodyItems : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("NextStartTime")]
            [Validation(Required=false)]
            public long? NextStartTime { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("DatamaskStatus")]
            [Validation(Required=false)]
            public int? DatamaskStatus { get; set; }

            [NameInMap("ProcessTotalCount")]
            [Validation(Required=false)]
            public int? ProcessTotalCount { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("OcrStatus")]
            [Validation(Required=false)]
            public int? OcrStatus { get; set; }

            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            [NameInMap("SupportScan")]
            [Validation(Required=false)]
            public bool? SupportScan { get; set; }

            [NameInMap("LastFinishedTime")]
            [Validation(Required=false)]
            public long? LastFinishedTime { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            [NameInMap("SupportOcr")]
            [Validation(Required=false)]
            public bool? SupportOcr { get; set; }

            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("SupportAudit")]
            [Validation(Required=false)]
            public bool? SupportAudit { get; set; }

            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            [NameInMap("SupportDatamask")]
            [Validation(Required=false)]
            public bool? SupportDatamask { get; set; }

            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            [NameInMap("DataLimitList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitsInstanceDimResponseBodyItemsDataLimitList> DataLimitList { get; set; }
            public class DescribeDataLimitsInstanceDimResponseBodyItemsDataLimitList : TeaModel {
                [NameInMap("SupportEvent")]
                [Validation(Required=false)]
                public bool? SupportEvent { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public int? CheckStatus { get; set; }

                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("NextStartTime")]
                [Validation(Required=false)]
                public long? NextStartTime { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("CheckStatusName")]
                [Validation(Required=false)]
                public string CheckStatusName { get; set; }

                [NameInMap("SamplingSize")]
                [Validation(Required=false)]
                public int? SamplingSize { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("DatamaskStatus")]
                [Validation(Required=false)]
                public int? DatamaskStatus { get; set; }

                [NameInMap("ProcessTotalCount")]
                [Validation(Required=false)]
                public int? ProcessTotalCount { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public long? ResourceType { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("OcrStatus")]
                [Validation(Required=false)]
                public int? OcrStatus { get; set; }

                [NameInMap("LogStoreDay")]
                [Validation(Required=false)]
                public int? LogStoreDay { get; set; }

                [NameInMap("EventStatus")]
                [Validation(Required=false)]
                public int? EventStatus { get; set; }

                [NameInMap("SupportScan")]
                [Validation(Required=false)]
                public bool? SupportScan { get; set; }

                [NameInMap("LastFinishedTime")]
                [Validation(Required=false)]
                public long? LastFinishedTime { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public int? AuditStatus { get; set; }

                [NameInMap("AutoCreateAccount")]
                [Validation(Required=false)]
                public bool? AutoCreateAccount { get; set; }

                [NameInMap("SupportOcr")]
                [Validation(Required=false)]
                public bool? SupportOcr { get; set; }

                [NameInMap("EngineType")]
                [Validation(Required=false)]
                public string EngineType { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public string DbVersion { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("SupportAudit")]
                [Validation(Required=false)]
                public bool? SupportAudit { get; set; }

                [NameInMap("AutoScan")]
                [Validation(Required=false)]
                public int? AutoScan { get; set; }

                [NameInMap("ResourceTypeCode")]
                [Validation(Required=false)]
                public string ResourceTypeCode { get; set; }

                [NameInMap("SupportDatamask")]
                [Validation(Required=false)]
                public bool? SupportDatamask { get; set; }

                [NameInMap("ProcessStatus")]
                [Validation(Required=false)]
                public int? ProcessStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

            }

        }

    }

}
