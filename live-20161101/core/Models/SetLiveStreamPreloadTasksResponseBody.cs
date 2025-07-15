// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamPreloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of URLs for which the prefetch task configuration failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedURL")]
        [Validation(Required=false)]
        public int? FailedURL { get; set; }

        /// <summary>
        /// <para>The details of the prefetch task.</para>
        /// </summary>
        [NameInMap("PreloadTasksMessages")]
        [Validation(Required=false)]
        public SetLiveStreamPreloadTasksResponseBodyPreloadTasksMessages PreloadTasksMessages { get; set; }
        public class SetLiveStreamPreloadTasksResponseBodyPreloadTasksMessages : TeaModel {
            [NameInMap("PreloadTasksMessage")]
            [Validation(Required=false)]
            public List<SetLiveStreamPreloadTasksResponseBodyPreloadTasksMessagesPreloadTasksMessage> PreloadTasksMessage { get; set; }
            public class SetLiveStreamPreloadTasksResponseBodyPreloadTasksMessagesPreloadTasksMessage : TeaModel {
                /// <summary>
                /// <para>Indicates whether the prefetch task is successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Successfully</description></item>
                /// <item><description>InternalError</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The streaming URL.</para>
                /// </summary>
                [NameInMap("PlayUrl")]
                [Validation(Required=false)]
                public string PlayUrl { get; set; }

                /// <summary>
                /// <para>The ID of the prefetch task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourTaskId</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36E0E523-E0C6-5D95-A465-A8EA2DCBA2A5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the prefetch task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// <remarks>
        /// <para> Success is returned only if the prefetch task is configured for all specified streaming URLs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of URLs for which the prefetch task is successfully configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessURL")]
        [Validation(Required=false)]
        public int? SuccessURL { get; set; }

        /// <summary>
        /// <para>The total number of URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalURL")]
        [Validation(Required=false)]
        public int? TotalURL { get; set; }

    }

}
