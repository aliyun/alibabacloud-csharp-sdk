// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the job.</para>
        /// </summary>
        [NameInMap("PreprocessJobs")]
        [Validation(Required=false)]
        public SubmitPreprocessJobsResponseBodyPreprocessJobs PreprocessJobs { get; set; }
        public class SubmitPreprocessJobsResponseBodyPreprocessJobs : TeaModel {
            [NameInMap("PreprocessJob")]
            [Validation(Required=false)]
            public List<SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob> PreprocessJob { get; set; }
            public class SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob : TeaModel {
                /// <summary>
                /// <para>The ID of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bb396607fd11fee9effbb99c4****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
