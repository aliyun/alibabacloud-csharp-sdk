// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSetsResponseBody : TeaModel {
        [NameInMap("DataSets")]
        [Validation(Required=false)]
        public List<ListDataSetsResponseBodyDataSets> DataSets { get; set; }
        public class ListDataSetsResponseBodyDataSets : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DataSetDescription")]
            [Validation(Required=false)]
            public string DataSetDescription { get; set; }

            [NameInMap("DataSetFieldKeyName")]
            [Validation(Required=false)]
            public string DataSetFieldKeyName { get; set; }

            [NameInMap("DataSetFieldNames")]
            [Validation(Required=false)]
            public string DataSetFieldNames { get; set; }

            [NameInMap("DataSetFileName")]
            [Validation(Required=false)]
            public string DataSetFileName { get; set; }

            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            [NameInMap("DataSetReferences")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsDataSetReferences> DataSetReferences { get; set; }
            public class ListDataSetsResponseBodyDataSetsDataSetReferences : TeaModel {
                [NameInMap("DataSetId")]
                [Validation(Required=false)]
                public string DataSetId { get; set; }

                [NameInMap("DataSetReferenceId")]
                [Validation(Required=false)]
                public string DataSetReferenceId { get; set; }

                [NameInMap("DataSetReferenceName")]
                [Validation(Required=false)]
                public string DataSetReferenceName { get; set; }

                [NameInMap("DataSetReferenceType")]
                [Validation(Required=false)]
                public string DataSetReferenceType { get; set; }

            }

            [NameInMap("DataSetStatus")]
            [Validation(Required=false)]
            public int? DataSetStatus { get; set; }

            [NameInMap("DataSetType")]
            [Validation(Required=false)]
            public string DataSetType { get; set; }

            [NameInMap("IpWhitelistRecognizers")]
            [Validation(Required=false)]
            public List<ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
            public class ListDataSetsResponseBodyDataSetsIpWhitelistRecognizers : TeaModel {
                [NameInMap("AutoRecognizeStatus")]
                [Validation(Required=false)]
                public string AutoRecognizeStatus { get; set; }

                [NameInMap("IpWhitelistRecognizerType")]
                [Validation(Required=false)]
                public string IpWhitelistRecognizerType { get; set; }

                [NameInMap("RecognizeScope")]
                [Validation(Required=false)]
                public string RecognizeScope { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
