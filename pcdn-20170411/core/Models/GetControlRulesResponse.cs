// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetControlRulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("SettingList")]
        [Validation(Required=true)]
        public GetControlRulesResponseSettingList SettingList { get; set; }
        public class GetControlRulesResponseSettingList : TeaModel {
            [NameInMap("Setting")]
            [Validation(Required=true)]
            public List<GetControlRulesResponseSettingListSetting> Setting { get; set; }
            public class GetControlRulesResponseSettingListSetting : TeaModel {
                public string PlatformType { get; set; }
                public string AppVersion { get; set; }
                public string IspName { get; set; }
                public string BusinessType { get; set; }
                public string ClientId { get; set; }
                public string CreatedAt { get; set; }
                public string MarketType { get; set; }
                public string Name { get; set; }
                public bool? Onoff { get; set; }
                public bool? Usable { get; set; }
                public string Region { get; set; }
                public string ResourceId { get; set; }
                public string UpdatedAt { get; set; }
            }
        };

        [NameInMap("Pager")]
        [Validation(Required=true)]
        public GetControlRulesResponsePager Pager { get; set; }
        public class GetControlRulesResponsePager : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=true)]
            public int? Page { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
        };

    }

}
