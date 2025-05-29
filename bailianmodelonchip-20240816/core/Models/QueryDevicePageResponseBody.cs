// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class QueryDevicePageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryDevicePageResponseBodyData Data { get; set; }
        public class QueryDevicePageResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryDevicePageResponseBodyDataData> Data { get; set; }
            public class QueryDevicePageResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-15 09:44:32</para>
                /// </summary>
                [NameInMap("activeTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1539704706413278</para>
                /// </summary>
                [NameInMap("aliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>202504010001</para>
                /// </summary>
                [NameInMap("batchNo")]
                [Validation(Required=false)]
                public string BatchNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5b504f84b69b9a73d3a21a2cff05e190</para>
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("disableStatus")]
                [Validation(Required=false)]
                public int? DisableStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-04-27 09:10:31</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-04-27 09:10:31</para>
                /// </summary>
                [NameInMap("gmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>201</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nnjNQQv3ZjyYE7H4</para>
                /// </summary>
                [NameInMap("productKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>493303079000577</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60FD351B-10C4-5C2C-ADA2-524FC39FC174</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
