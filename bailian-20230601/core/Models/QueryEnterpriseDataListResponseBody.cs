// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class QueryEnterpriseDataListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEnterpriseDataListResponseBodyData Data { get; set; }
        public class QueryEnterpriseDataListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryEnterpriseDataListResponseBodyDataList> List { get; set; }
            public class QueryEnterpriseDataListResponseBodyDataList : TeaModel {
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("DataName")]
                [Validation(Required=false)]
                public string DataName { get; set; }

                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public string DataSize { get; set; }

                [NameInMap("DataStatus")]
                [Validation(Required=false)]
                public string DataStatus { get; set; }

                [NameInMap("DataStatusCode")]
                [Validation(Required=false)]
                public int? DataStatusCode { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("DataTypeCode")]
                [Validation(Required=false)]
                public int? DataTypeCode { get; set; }

                [NameInMap("StatusDetail")]
                [Validation(Required=false)]
                public string StatusDetail { get; set; }

                [NameInMap("StoreType")]
                [Validation(Required=false)]
                public string StoreType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("UploadTime")]
                [Validation(Required=false)]
                public string UploadTime { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
