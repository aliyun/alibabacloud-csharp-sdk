// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobResponseBody : TeaModel {
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public SubmitAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class SubmitAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<SubmitAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class SubmitAIJobResponseBodyAIJobListAIJob : TeaModel {
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D73936****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
