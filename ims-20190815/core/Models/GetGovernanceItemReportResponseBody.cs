// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetGovernanceItemReportResponseBody : TeaModel {
        [NameInMap("ColumnsSchema")]
        [Validation(Required=false)]
        public GetGovernanceItemReportResponseBodyColumnsSchema ColumnsSchema { get; set; }
        public class GetGovernanceItemReportResponseBodyColumnsSchema : TeaModel {
            [NameInMap("ColumnSchema")]
            [Validation(Required=false)]
            public List<GetGovernanceItemReportResponseBodyColumnsSchemaColumnSchema> ColumnSchema { get; set; }
            public class GetGovernanceItemReportResponseBodyColumnsSchemaColumnSchema : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

            }

        }

        [NameInMap("ColumnsValue")]
        [Validation(Required=false)]
        public GetGovernanceItemReportResponseBodyColumnsValue ColumnsValue { get; set; }
        public class GetGovernanceItemReportResponseBodyColumnsValue : TeaModel {
            [NameInMap("ColumnRow")]
            [Validation(Required=false)]
            public List<GetGovernanceItemReportResponseBodyColumnsValueColumnRow> ColumnRow { get; set; }
            public class GetGovernanceItemReportResponseBodyColumnsValueColumnRow : TeaModel {
                [NameInMap("ColumnValue")]
                [Validation(Required=false)]
                public List<object> ColumnValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the report for the check item was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-19T15:06:52Z</para>
        /// </summary>
        [NameInMap("GenerateTime")]
        [Validation(Required=false)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>This parameter is returned only when <c>IsTruncated</c> is set to true. Use this parameter to retrieve the truncated content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The data type of the metric value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Number: the numeric type.</para>
        /// </description></item>
        /// <item><description><para>String: the string type.</para>
        /// </description></item>
        /// <item><description><para>Boolean: the Boolean type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Number</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The metric value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MetricValue")]
        [Validation(Required=false)]
        public object MetricValue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2CE9688-AA85-5F23-8C22-0EC23473405F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
