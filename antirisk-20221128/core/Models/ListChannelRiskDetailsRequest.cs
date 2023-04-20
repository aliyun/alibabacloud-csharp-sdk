// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class ListChannelRiskDetailsRequest : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("isAllChannel")]
        [Validation(Required=false)]
        public string IsAllChannel { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
