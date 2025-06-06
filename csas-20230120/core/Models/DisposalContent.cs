// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DisposalContent : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AlertContent")]
        [Validation(Required=false)]
        public string AlertContent { get; set; }

        [NameInMap("AlertContentEn")]
        [Validation(Required=false)]
        public string AlertContentEn { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AlertTitle")]
        [Validation(Required=false)]
        public string AlertTitle { get; set; }

        [NameInMap("AlertTitleEn")]
        [Validation(Required=false)]
        public string AlertTitleEn { get; set; }

        [NameInMap("NacDemotionPolicyIds")]
        [Validation(Required=false)]
        public List<string> NacDemotionPolicyIds { get; set; }

        [NameInMap("NoticeContent")]
        [Validation(Required=false)]
        public string NoticeContent { get; set; }

        [NameInMap("NoticeContentEn")]
        [Validation(Required=false)]
        public string NoticeContentEn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("NotifyActions")]
        [Validation(Required=false)]
        public List<string> NotifyActions { get; set; }

        [NameInMap("ProhibitActions")]
        [Validation(Required=false)]
        public List<string> ProhibitActions { get; set; }

    }

}
