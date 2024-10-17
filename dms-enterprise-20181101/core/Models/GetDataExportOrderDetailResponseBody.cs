// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data export ticket.</para>
        /// </summary>
        [NameInMap("DataExportOrderDetail")]
        [Validation(Required=false)]
        public GetDataExportOrderDetailResponseBodyDataExportOrderDetail DataExportOrderDetail { get; set; }
        public class GetDataExportOrderDetailResponseBodyDataExportOrderDetail : TeaModel {
            /// <summary>
            /// <para>The information about the ticket.</para>
            /// </summary>
            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo : TeaModel {
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The state of the data export ticket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PRE_CHECKING</b>: The ticket was being prechecked.</description></item>
                /// <item><description><b>PRE_CHECK_SUCCESS</b>: The ticket passed the precheck.</description></item>
                /// <item><description><b>PRE_CHECK_FAIL</b>: The ticket failed to pass the prechecked.</description></item>
                /// <item><description><b>WAITING_APPLY_AUDIT</b>: The ticket was to be submitted for approval.</description></item>
                /// <item><description><b>APPLY_AUDIT_SUCCESS</b>: The ticket was submitted for approval.</description></item>
                /// <item><description><b>ENABLE_EXPORT</b>: The ticket was approved. Data can be exported.</description></item>
                /// <item><description><b>WAITING_EXPORT</b>: Data was to be scheduled for export.</description></item>
                /// <item><description><b>DOING_EXPORT</b>: Data was being exported.</description></item>
                /// <item><description><b>EXPORT_FAIL</b>: Data failed to be exported.</description></item>
                /// <item><description><b>EXPORT_SUCCESS</b>: Data was exported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EXPORT_SUCCESS</para>
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// <para>The precheck ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PreCheckId")]
                [Validation(Required=false)]
                public long? PreCheckId { get; set; }

            }

            /// <summary>
            /// <para>The details of the ticket.</para>
            /// </summary>
            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail : TeaModel {
                /// <summary>
                /// <para>The number of rows that were affected by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                /// <summary>
                /// <para>The category of the reason for the data export.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// <para>The name of the database from which data was exported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx@xxx:3306</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The ID of the database from which data was exported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the database belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The SQL statement that was executed to export data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select 1</para>
                /// </summary>
                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                /// <summary>
                /// <para>Indicates whether the affected rows are skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                /// <summary>
                /// <para>The reason why the affected rows are skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>empty</para>
                /// </summary>
                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>427688B8-ADFB-4C4E-9D45-EF5C1FD6E23D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values:</para>
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
