// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The list of Alibaba Cloud accounts that belong to the resource directory members for which quotas are applied.</para>
        /// </summary>
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        /// <summary>
        /// <para>The batch ID of the quota application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        /// <summary>
        /// <para>The list of Alibaba Cloud accounts that belong to the resource directory members for which quota applications failed and the reasons for the failures.</para>
        /// </summary>
        [NameInMap("FailResults")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateResponseBodyFailResults> FailResults { get; set; }
        public class CreateQuotaApplicationsForTemplateResponseBodyFailResults : Darabonba.Model {
            /// <summary>
            /// <para>The Alibaba Cloud account that belongs to the resource directory member for which the quota application failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135048337611****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
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

