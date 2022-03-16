// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListInstanceServiceConfigurationsResponseBody : TeaModel {
        [NameInMap("ConfigureList")]
        [Validation(Required=false)]
        public ListInstanceServiceConfigurationsResponseBodyConfigureList ConfigureList { get; set; }
        public class ListInstanceServiceConfigurationsResponseBodyConfigureList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<ListInstanceServiceConfigurationsResponseBodyConfigureListConfig> Config { get; set; }
            public class ListInstanceServiceConfigurationsResponseBodyConfigureListConfig : TeaModel {
                public string ConfigureName { get; set; }
                public string ConfigureUnit { get; set; }
                public string DefaultValue { get; set; }
                public string Description { get; set; }
                public string NeedRestart { get; set; }
                public string RunningValue { get; set; }
                public string ValueRange { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
