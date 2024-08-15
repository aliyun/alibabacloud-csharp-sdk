// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DataBonreeSDKConfigModuleConfigVersionConfigsValue : TeaModel {
        [NameInMap("useCustom")]
        [Validation(Required=false)]
        public bool? UseCustom { get; set; }

        [NameInMap("customConfig")]
        [Validation(Required=false)]
        public Dictionary<string, DataBonreeSDKConfigModuleConfigVersionConfigsValueCustomConfigValue> CustomConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
