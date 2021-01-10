// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SwitchLinkeBahamutAdminswitchlinkqRequest : TeaModel {
        [NameInMap("AppNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AppNamesRepeatList { get; set; }

        [NameInMap("OpoType")]
        [Validation(Required=false)]
        public string OpoType { get; set; }

        [NameInMap("TenantPath")]
        [Validation(Required=false)]
        public string TenantPath { get; set; }

    }

}
