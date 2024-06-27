// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeVariableListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeVariableListResponseBodyResultObject : TeaModel {
            [NameInMap("capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            [NameInMap("defineId")]
            [Validation(Required=false)]
            public string DefineId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("leftCapacity")]
            [Validation(Required=false)]
            public long? LeftCapacity { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputsType")]
            [Validation(Required=false)]
            public string OutputsType { get; set; }

            [NameInMap("refObjId")]
            [Validation(Required=false)]
            public string RefObjId { get; set; }

            [NameInMap("refObjName")]
            [Validation(Required=false)]
            public string RefObjName { get; set; }

            [NameInMap("refObjType")]
            [Validation(Required=false)]
            public string RefObjType { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
