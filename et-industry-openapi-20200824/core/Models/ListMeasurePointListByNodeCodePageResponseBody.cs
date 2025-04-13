// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Et_industry_openapi20200824.Models
{
    public class ListMeasurePointListByNodeCodePageResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListMeasurePointListByNodeCodePageResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListMeasurePointListByNodeCodePageResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMeasurePointListByNodeCodePageResponseBodyData Data { get; set; }
        public class ListMeasurePointListByNodeCodePageResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListMeasurePointListByNodeCodePageResponseBodyDataDataList> DataList { get; set; }
            public class ListMeasurePointListByNodeCodePageResponseBodyDataDataList : TeaModel {
                [NameInMap("AcqFreq")]
                [Validation(Required=false)]
                public string AcqFreq { get; set; }

                [NameInMap("AlarmAttribute")]
                [Validation(Required=false)]
                public string AlarmAttribute { get; set; }

                [NameInMap("AlarmLevel")]
                [Validation(Required=false)]
                public string AlarmLevel { get; set; }

                [NameInMap("CalcAttribute")]
                [Validation(Required=false)]
                public string CalcAttribute { get; set; }

                [NameInMap("CalcFormula")]
                [Validation(Required=false)]
                public string CalcFormula { get; set; }

                [NameInMap("CalcType")]
                [Validation(Required=false)]
                public string CalcType { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ErrMsgDetail")]
                [Validation(Required=false)]
                public string ErrMsgDetail { get; set; }

                [NameInMap("FullName")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public long? GmtModify { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("InitValue")]
                [Validation(Required=false)]
                public string InitValue { get; set; }

                [NameInMap("IsEnable")]
                [Validation(Required=false)]
                public string IsEnable { get; set; }

                [NameInMap("LastUploadTime")]
                [Validation(Required=false)]
                public string LastUploadTime { get; set; }

                [NameInMap("LatestValue")]
                [Validation(Required=false)]
                public string LatestValue { get; set; }

                [NameInMap("LowerLimit")]
                [Validation(Required=false)]
                public string LowerLimit { get; set; }

                [NameInMap("MeasurePointState")]
                [Validation(Required=false)]
                public string MeasurePointState { get; set; }

                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NodeCode")]
                [Validation(Required=false)]
                public string NodeCode { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public int? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("ParentFullName")]
                [Validation(Required=false)]
                public string ParentFullName { get; set; }

                [NameInMap("PayLoad")]
                [Validation(Required=false)]
                public string PayLoad { get; set; }

                [NameInMap("ProtocolConfig")]
                [Validation(Required=false)]
                public string ProtocolConfig { get; set; }

                [NameInMap("SourcePoint")]
                [Validation(Required=false)]
                public string SourcePoint { get; set; }

                [NameInMap("TenantCode")]
                [Validation(Required=false)]
                public string TenantCode { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public string UpperLimit { get; set; }

            }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
