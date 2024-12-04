// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDistributeTableListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDistributeTableListResponseBodyData Data { get; set; }
        public class DescribeDistributeTableListResponseBodyData : TeaModel {
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDistributeTableListResponseBodyDataTables> Tables { get; set; }
            public class DescribeDistributeTableListResponseBodyDataTables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("DbKey")]
                [Validation(Required=false)]
                public string DbKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sbtest1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>multi</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("TbKey")]
                [Validation(Required=false)]
                public string TbKey { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
