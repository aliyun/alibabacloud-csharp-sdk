// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAModuleVersionsByDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAModuleVersionsByDeviceResponseBodyData Data { get; set; }
        public class ListOTAModuleVersionsByDeviceResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAModuleInfo")]
            [Validation(Required=false)]
            public List<ListOTAModuleVersionsByDeviceResponseBodyDataSimpleOTAModuleInfo> SimpleOTAModuleInfo { get; set; }
            public class ListOTAModuleVersionsByDeviceResponseBodyDataSimpleOTAModuleInfo : TeaModel {
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public string IotId { get; set; }
                public string ModuleVersion { get; set; }
                public string ModuleName { get; set; }
            }
        };

    }

}
