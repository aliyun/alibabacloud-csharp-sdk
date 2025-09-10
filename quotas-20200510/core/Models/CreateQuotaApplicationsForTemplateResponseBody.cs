// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud accounts for which the quotas are applied.</para>
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// <para>The ID of the quota application batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud accounts of the members in a resource directory whose quota increase request is rejected, and the reason for the rejection.</para>
        /// </summary>
        [NameInMap("FailResults")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateResponseBodyFailResults> FailResults { get; set; }
        public class CreateQuotaApplicationsForTemplateResponseBodyFailResults : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account of the members in a resource directory whose quota increase request is rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135048337611****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The reason for the rejection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The quota adjustment application is being processed. Please try again later.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FF8CAF0-29D9-4F11-B6A4-FD2CBCA016D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
