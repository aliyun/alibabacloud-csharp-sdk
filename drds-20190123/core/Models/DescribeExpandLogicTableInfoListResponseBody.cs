// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeExpandLogicTableInfoListResponseBody : TeaModel {
        /// <summary>
        /// Indicates the result that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeExpandLogicTableInfoListResponseBodyData Data { get; set; }
        public class DescribeExpandLogicTableInfoListResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeExpandLogicTableInfoListResponseBodyDataData> Data { get; set; }
            public class DescribeExpandLogicTableInfoListResponseBodyDataData : TeaModel {
                /// <summary>
                /// Indicates the database sharding key.
                /// </summary>
                [NameInMap("ShardDbKey")]
                [Validation(Required=false)]
                public string ShardDbKey { get; set; }

                /// <summary>
                /// Indicates the table sharding key.
                /// </summary>
                [NameInMap("ShardTbKey")]
                [Validation(Required=false)]
                public string ShardTbKey { get; set; }

                /// <summary>
                /// Indicates the name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
