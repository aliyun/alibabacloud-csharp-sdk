// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListDeviceGroupsRequest : TeaModel {
        [NameInMap("DeviceCodeList")]
        [Validation(Required=false)]
        public string DeviceCodeList { get; set; }

        [NameInMap("CorpIdList")]
        [Validation(Required=false)]
        public string CorpIdList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("IsPage")]
        [Validation(Required=false)]
        public int? IsPage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

    }

}
