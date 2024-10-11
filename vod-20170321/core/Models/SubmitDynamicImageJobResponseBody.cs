// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the animated image job.</para>
        /// </summary>
        [NameInMap("DynamicImageJob")]
        [Validation(Required=false)]
        public SubmitDynamicImageJobResponseBodyDynamicImageJob DynamicImageJob { get; set; }
        public class SubmitDynamicImageJobResponseBodyDynamicImageJob : TeaModel {
            /// <summary>
            /// <para>The ID of the animated image job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad90a501b1bfb72374ad0050746****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-74A6-BEF6-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
