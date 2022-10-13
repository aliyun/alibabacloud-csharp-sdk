// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCalcEnginesResponseBodyData Data { get; set; }
        public class ListCalcEnginesResponseBodyData : TeaModel {
            [NameInMap("CalcEngines")]
            [Validation(Required=false)]
            public List<ListCalcEnginesResponseBodyDataCalcEngines> CalcEngines { get; set; }
            public class ListCalcEnginesResponseBodyDataCalcEngines : TeaModel {
                [NameInMap("BindingProjectId")]
                [Validation(Required=false)]
                public int? BindingProjectId { get; set; }

                [NameInMap("BindingProjectName")]
                [Validation(Required=false)]
                public string BindingProjectName { get; set; }

                [NameInMap("CalcEngineType")]
                [Validation(Required=false)]
                public string CalcEngineType { get; set; }

                [NameInMap("DwRegion")]
                [Validation(Required=false)]
                public string DwRegion { get; set; }

                [NameInMap("EngineId")]
                [Validation(Required=false)]
                public int? EngineId { get; set; }

                [NameInMap("EngineInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EngineInfo { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TaskAuthType")]
                [Validation(Required=false)]
                public string TaskAuthType { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
