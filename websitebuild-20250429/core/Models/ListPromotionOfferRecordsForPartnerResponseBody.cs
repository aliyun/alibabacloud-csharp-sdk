// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListPromotionOfferRecordsForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name. The application with this name is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>watermark</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the %s variable in the ErrMessage response parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The number of entries per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListPromotionOfferRecordsForPartnerResponseBodyModule Module { get; set; }
        public class ListPromotionOfferRecordsForPartnerResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of issuance records.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListPromotionOfferRecordsForPartnerResponseBodyModuleRecords> Records { get; set; }
            public class ListPromotionOfferRecordsForPartnerResponseBodyModuleRecords : TeaModel {
                /// <summary>
                /// <para>The activity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acwfradoj5u</para>
                /// </summary>
                [NameInMap("ActivityCode")]
                [Validation(Required=false)]
                public string ActivityCode { get; set; }

                /// <summary>
                /// <para>The activity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP网段过滤统计</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <para>The employee code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("EmployeeCode")]
                [Validation(Required=false)]
                public string EmployeeCode { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_ERROR</para>
                /// </summary>
                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                /// <summary>
                /// <para>The issuance time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-01</para>
                /// </summary>
                [NameInMap("IssuanceTime")]
                [Validation(Required=false)]
                public string IssuanceTime { get; set; }

                /// <summary>
                /// <para>The benefit snapshot in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OfferSnapshot")]
                [Validation(Required=false)]
                public string OfferSnapshot { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5094</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>The operation remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The issuance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FE_RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123241414</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The token for the next query. This parameter is empty if no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
