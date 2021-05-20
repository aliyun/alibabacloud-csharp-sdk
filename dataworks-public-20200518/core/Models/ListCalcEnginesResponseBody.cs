// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCalcEnginesResponseBodyData Data { get; set; }
        public class ListCalcEnginesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("CalcEngines")]
            [Validation(Required=false)]
            public List<ListCalcEnginesResponseBodyDataCalcEngines> CalcEngines { get; set; }
            public class ListCalcEnginesResponseBodyDataCalcEngines : TeaModel {
                public string BindingProjectName { get; set; }
                public bool? IsDefault { get; set; }
                public int? EngineId { get; set; }
                public string DwRegion { get; set; }
                public string TaskAuthType { get; set; }
                public string CalcEngineType { get; set; }
                public Dictionary<string, string> EngineInfo { get; set; }
                public string EnvType { get; set; }
                public string Region { get; set; }
                public string GmtCreate { get; set; }
                public int? BindingProjectId { get; set; }
                public string Name { get; set; }
                public long? TenantId { get; set; }
            }
        };

    }

}
