// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class ListDataSourcesResponseBodyDataSources : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
