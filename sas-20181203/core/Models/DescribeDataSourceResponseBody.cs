// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDataSourceResponseBody : TeaModel {
        [NameInMap("MetaDatas")]
        [Validation(Required=false)]
        public List<DescribeDataSourceResponseBodyMetaDatas> MetaDatas { get; set; }
        public class DescribeDataSourceResponseBodyMetaDatas : TeaModel {
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MetaDataFields")]
            [Validation(Required=false)]
            public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFields> MetaDataFields { get; set; }
            public class DescribeDataSourceResponseBodyMetaDatasMetaDataFields : TeaModel {
                [NameInMap("Filed")]
                [Validation(Required=false)]
                public string Filed { get; set; }

                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                [NameInMap("OperatorList")]
                [Validation(Required=false)]
                public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList> OperatorList { get; set; }
                public class DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
