// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListPublicDatasetResponseBody : TeaModel {
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<ListPublicDatasetResponseBodyDatasets> Datasets { get; set; }
        public class ListPublicDatasetResponseBodyDatasets : TeaModel {
            [NameInMap("About")]
            [Validation(Required=false)]
            public string About { get; set; }

            [NameInMap("AccessRequirements")]
            [Validation(Required=false)]
            public string AccessRequirements { get; set; }

            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public string Copyright { get; set; }

            [NameInMap("DatasetDescription")]
            [Validation(Required=false)]
            public string DatasetDescription { get; set; }

            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("UpdateFrequency")]
            [Validation(Required=false)]
            public string UpdateFrequency { get; set; }

        }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
