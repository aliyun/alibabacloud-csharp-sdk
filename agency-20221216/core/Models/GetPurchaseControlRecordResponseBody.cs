// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetPurchaseControlRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. Value range:</para>
        /// <list type="bullet">
        /// <item><description>200: OK.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPurchaseControlRecordResponseBodyData> Data { get; set; }
        public class GetPurchaseControlRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The change type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ban: new purchases are prohibited.</description></item>
            /// <item><description>cancelBan: the purchase prohibition is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ban</para>
            /// </summary>
            [NameInMap("ChangedType")]
            [Validation(Required=false)]
            public string ChangedType { get; set; }

            /// <summary>
            /// <para>The method by which the operation was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationPath")]
            [Validation(Required=false)]
            public string OperationPath { get; set; }

            /// <summary>
            /// <para>The operation time (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>292828565558721922</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

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
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
