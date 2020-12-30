// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetControlRulesResponseBody : TeaModel {
        [NameInMap("SettingList")]
        [Validation(Required=false)]
        public GetControlRulesResponseBodySettingList SettingList { get; set; }
        public class GetControlRulesResponseBodySettingList : TeaModel {
            [NameInMap("Setting")]
            [Validation(Required=false)]
            public List<GetControlRulesResponseBodySettingListSetting> Setting { get; set; }
            public class GetControlRulesResponseBodySettingListSetting : TeaModel {
                public string CreatedAt { get; set; }
                public string ClientId { get; set; }
                public string BusinessType { get; set; }
                public bool? Usable { get; set; }
                public string Region { get; set; }
                public string PlatformType { get; set; }
                public string MarketType { get; set; }
                public bool? Onoff { get; set; }
                public string IspName { get; set; }
                public string AppVersion { get; set; }
                public string UpdatedAt { get; set; }
                public string Name { get; set; }
                public string ResourceId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public GetControlRulesResponseBodyPager Pager { get; set; }
        public class GetControlRulesResponseBodyPager : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
