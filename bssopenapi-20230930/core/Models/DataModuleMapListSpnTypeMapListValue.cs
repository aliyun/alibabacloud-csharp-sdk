// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DataModuleMapListSpnTypeMapListValue : TeaModel {
        [NameInMap("FilterModules")]
        [Validation(Required=false)]
        public List<DataModuleMapListSpnTypeMapListValueFilterModules> FilterModules { get; set; }
        public class DataModuleMapListSpnTypeMapListValueFilterModules : TeaModel {
            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public long? ModuleId { get; set; }

            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        [NameInMap("ShowModules")]
        [Validation(Required=false)]
        public List<DataModuleMapListSpnTypeMapListValueShowModules> ShowModules { get; set; }
        public class DataModuleMapListSpnTypeMapListValueShowModules : TeaModel {
            [NameInMap("ModuleId")]
            [Validation(Required=false)]
            public long? ModuleId { get; set; }

            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

    }

}
