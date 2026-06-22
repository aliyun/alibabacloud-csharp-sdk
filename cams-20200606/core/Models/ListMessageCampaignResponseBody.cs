// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMessageCampaignResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Example</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMessageCampaignResponseBodyData> Data { get; set; }
        public class ListMessageCampaignResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Meta ad account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2339**</para>
            /// </summary>
            [NameInMap("AdAccountId")]
            [Validation(Required=false)]
            public string AdAccountId { get; set; }

            /// <summary>
            /// <para>The budget.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("Budget")]
            [Validation(Required=false)]
            public long? Budget { get; set; }

            /// <summary>
            /// <para>The budget type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            /// <summary>
            /// <para>The campaign ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233**</para>
            /// </summary>
            [NameInMap("CampaignId")]
            [Validation(Required=false)]
            public string CampaignId { get; set; }

            /// <summary>
            /// <para>The name of the campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>campaign-name</para>
            /// </summary>
            [NameInMap("CampaignName")]
            [Validation(Required=false)]
            public string CampaignName { get; set; }

            /// <summary>
            /// <para>The time when the campaign was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173029392838</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The Page ID for Messenger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>238***</para>
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <para>The status of the campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: successful.</para>
        /// </description></item>
        /// <item><description><para>false: failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
