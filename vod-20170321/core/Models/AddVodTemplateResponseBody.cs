// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot or animated image template.
        /// You can use this ID as a request parameter in the <a href="~~SubmitSnapshotJob~~">SubmitSnapshotJob</a> or <a href="~~SubmitDynamicImageJob~~">SubmitDynamicImageJob</a> operation to initiate snapshot or animated image processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f5b228fe6930e*****0d6bf55bd87789</para>
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
