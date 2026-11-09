// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CancelGenerationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag_77b5f78b***</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. The value is Canceled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Canceled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
