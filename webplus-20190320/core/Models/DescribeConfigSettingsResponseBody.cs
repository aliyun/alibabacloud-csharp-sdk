// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeConfigSettingsResponseBody : TeaModel {
        [NameInMap("ConfigSettings")]
        [Validation(Required=false)]
        public DescribeConfigSettingsResponseBodyConfigSettings ConfigSettings { get; set; }
        public class DescribeConfigSettingsResponseBodyConfigSettings : TeaModel {
            [NameInMap("ConfigSetting")]
            [Validation(Required=false)]
            public List<DescribeConfigSettingsResponseBodyConfigSettingsConfigSetting> ConfigSetting { get; set; }
            public class DescribeConfigSettingsResponseBodyConfigSettingsConfigSetting : TeaModel {
                public string OptionName { get; set; }
                public string PathName { get; set; }
                public string SettingValue { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
