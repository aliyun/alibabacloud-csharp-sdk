// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDataCheckTableDiffDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the database in the source instance that contains the table with inconsistent data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_dtstest</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The number of rows with data inconsistency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DiffCount")]
        [Validation(Required=false)]
        public long? DiffCount { get; set; }

        /// <summary>
        /// <para>The inconsistency details.</para>
        /// </summary>
        [NameInMap("DiffDetails")]
        [Validation(Required=false)]
        public List<DescribeDataCheckTableDiffDetailsResponseBodyDiffDetails> DiffDetails { get; set; }
        public class DescribeDataCheckTableDiffDetailsResponseBodyDiffDetails : TeaModel {
            /// <summary>
            /// <para>The specific inconsistency details, which is a JSON string.</para>
            /// <list type="bullet">
            /// <item><description>column: the field name.</description></item>
            /// <item><description>source: the value in the source database.</description></item>
            /// <item><description>dest: the value in the destination database.</description></item>
            /// <item><description>isPrimary: indicates whether the field is a primary key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[     {         &quot;column&quot;: &quot;id&quot;,         &quot;source&quot;: &quot;9511&quot;,         &quot;dest&quot;: &quot;9511&quot;,         &quot;isPrimary&quot;: true     },     {         &quot;column&quot;: &quot;state&quot;,         &quot;source&quot;: &quot;3&quot;,         &quot;dest&quot;: &quot;2&quot;,         &quot;isPrimary&quot;: false     },     {         &quot;column&quot;: &quot;create_time&quot;,         &quot;source&quot;: &quot;2023-04-11 14:07:17.0&quot;,         &quot;dest&quot;: &quot;NULL&quot;,         &quot;isPrimary&quot;: false     },     {         &quot;column&quot;: &quot;update_time&quot;,         &quot;source&quot;: &quot;2023-04-11 06:07:17.0&quot;,         &quot;dest&quot;: &quot;2023-04-11 06:02:29.0&quot;,         &quot;isPrimary&quot;: false     } ]</para>
            /// </summary>
            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            /// <summary>
            /// <para>The time when the verification was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23T10:36:05.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The auto-increment primary key that identifies a verification result record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13058****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the <b>%s</b> placeholder in the <b>ErrMessage</b> response element.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>Type</b>, the request parameter <b>Type</b> that you specified is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The value of the parameter tbName is invalid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsog8q1z3tc9t****&quot;</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The name of the table in the source database that contains inconsistent data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_person</para>
        /// </summary>
        [NameInMap("TbName")]
        [Validation(Required=false)]
        public string TbName { get; set; }

    }

}
