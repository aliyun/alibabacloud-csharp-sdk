// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutAppgroupRequest : TeaModel {
        [NameInMap("AdminsRepeatList")]
        [Validation(Required=false)]
        public List<string> AdminsRepeatList { get; set; }

        [NameInMap("AppListRepeatList")]
        [Validation(Required=false)]
        public List<string> AppListRepeatList { get; set; }

        [NameInMap("BahamutTenant")]
        [Validation(Required=false)]
        public string BahamutTenant { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
