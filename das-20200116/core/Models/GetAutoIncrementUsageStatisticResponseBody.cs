// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoIncrementUsageStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoIncrementUsageStatisticResponseBodyData Data { get; set; }
        public class GetAutoIncrementUsageStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage details of auto-increment IDs.</para>
            /// </summary>
            [NameInMap("AutoIncrementUsageList")]
            [Validation(Required=false)]
            public List<GetAutoIncrementUsageStatisticResponseBodyDataAutoIncrementUsageList> AutoIncrementUsageList { get; set; }
            public class GetAutoIncrementUsageStatisticResponseBodyDataAutoIncrementUsageList : TeaModel {
                /// <summary>
                /// <para>The latest auto-increment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2147483647</para>
                /// </summary>
                [NameInMap("AutoIncrementCurrentValue")]
                [Validation(Required=false)]
                public long? AutoIncrementCurrentValue { get; set; }

                /// <summary>
                /// <para>The usage ratio of auto-increment IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AutoIncrementRatio")]
                [Validation(Required=false)]
                public double? AutoIncrementRatio { get; set; }

                /// <summary>
                /// <para>The column name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db01</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The maximum auto-increment ID that is supported by the current data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2147483647</para>
                /// </summary>
                [NameInMap("MaximumValue")]
                [Validation(Required=false)]
                public long? MaximumValue { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The error message returned if the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>the given database name list invalid, none of the database names in the list exist on the instance</para>
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public bool? Finish { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
            /// <item><description><b>RUNNING</b>: The task is being executed.</description></item>
            /// <item><description><b>SUCCESS</b>: The task succeeds.</description></item>
            /// <item><description><b>FAIL</b>: The task fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The time when the request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1697183353000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
