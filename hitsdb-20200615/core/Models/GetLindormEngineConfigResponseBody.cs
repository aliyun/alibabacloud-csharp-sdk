// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormEngineConfigResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("EngineConfigs")]
        [Validation(Required=false)]
        public List<GetLindormEngineConfigResponseBodyEngineConfigs> EngineConfigs { get; set; }
        public class GetLindormEngineConfigResponseBodyEngineConfigs : TeaModel {
            [NameInMap("ConfigFiles")]
            [Validation(Required=false)]
            public List<GetLindormEngineConfigResponseBodyEngineConfigsConfigFiles> ConfigFiles { get; set; }
            public class GetLindormEngineConfigResponseBodyEngineConfigsConfigFiles : TeaModel {
                [NameInMap("ConfigItems")]
                [Validation(Required=false)]
                public List<GetLindormEngineConfigResponseBodyEngineConfigsConfigFilesConfigItems> ConfigItems { get; set; }
                public class GetLindormEngineConfigResponseBodyEngineConfigsConfigFilesConfigItems : TeaModel {
                    [NameInMap("ConfigItemKey")]
                    [Validation(Required=false)]
                    public string ConfigItemKey { get; set; }

                    [NameInMap("ConfigItemValue")]
                    [Validation(Required=false)]
                    public string ConfigItemValue { get; set; }

                }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
