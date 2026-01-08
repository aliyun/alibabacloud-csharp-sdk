// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMessageCampaignResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMessageCampaignResponseBodyData> Data { get; set; }
        public class ListMessageCampaignResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2339**</para>
            /// </summary>
            [NameInMap("AdAccountId")]
            [Validation(Required=false)]
            public string AdAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("Budget")]
            [Validation(Required=false)]
            public long? Budget { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>233**</para>
            /// </summary>
            [NameInMap("CampaignId")]
            [Validation(Required=false)]
            public string CampaignId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>campaign-name</para>
            /// </summary>
            [NameInMap("CampaignName")]
            [Validation(Required=false)]
            public string CampaignName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173029392838</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>238***</para>
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
