// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class ListUserSolutionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserSolutionsResponseBodyData> Data { get; set; }
        public class ListUserSolutionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>S20210924151843000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esp.logo</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>164454443222</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>P20210924151843000001</para>
            /// </summary>
            [NameInMap("DeliveryOrderBizId")]
            [Validation(Required=false)]
            public string DeliveryOrderBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A20210924151843000001</para>
            /// </summary>
            [NameInMap("IntentionAssignBizId")]
            [Validation(Required=false)]
            public string IntentionAssignBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>I20210924151843000001</para>
            /// </summary>
            [NameInMap("IntentionBizId")]
            [Validation(Required=false)]
            public string IntentionBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jinsan</para>
            /// </summary>
            [NameInMap("PartnerCode")]
            [Validation(Required=false)]
            public string PartnerCode { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>164454443222</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1219541161213057</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2174AA97-56FB-50FA-B243-0460B9E4CE0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>344</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
