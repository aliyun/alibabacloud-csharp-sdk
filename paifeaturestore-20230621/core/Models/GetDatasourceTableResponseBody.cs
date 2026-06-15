// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetDatasourceTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetDatasourceTableResponseBodyFields> Fields { get; set; }
        public class GetDatasourceTableResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>The attributes of the field. Valid values:</para>
            /// <para>● Partition: indicates that the field is a partition field.</para>
            /// <para>● EventTime: indicates that the field is an event time field.</para>
            /// <para>● PrimaryKey: indicates that the field is a primary key field.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>field1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type of the field. Valid values:</para>
            /// <para>● INT32</para>
            /// <para>● INT64</para>
            /// <para>● FLOAT</para>
            /// <para>● DOUBLE</para>
            /// <para>● STRING</para>
            /// <para>● BOOLEAN</para>
            /// <para>● TIMESTAMP</para>
            /// 
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7B2F8C4-49C7-5CFA-8075-9D715A114873</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
