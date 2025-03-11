// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeExpandLogicTableInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the result that is returned.</para>
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
                /// <para>Indicates the database sharding key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("ShardDbKey")]
                [Validation(Required=false)]
                public string ShardDbKey { get; set; }

                /// <summary>
                /// <para>Indicates the table sharding key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>address</para>
                /// </summary>
                [NameInMap("ShardTbKey")]
                [Validation(Required=false)]
                public string ShardTbKey { get; set; }

                /// <summary>
                /// <para>Indicates the name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>employee_split2</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B6B7BDC-575D-4A77-A4F8-24B7EF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
