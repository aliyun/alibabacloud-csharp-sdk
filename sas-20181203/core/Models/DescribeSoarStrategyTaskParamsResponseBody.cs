// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTaskParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BR****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public DescribeSoarStrategyTaskParamsResponseBodyTaskDetail TaskDetail { get; set; }
        public class DescribeSoarStrategyTaskParamsResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// <para>The task parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;summary&quot;:[{&quot;name&quot;:&quot;email&quot;,&quot;type&quot;:&quot;String&quot;,&quot;isRequired&quot;:false,&quot;fromProperty&quot;:&quot;notifyConfig.email&quot;}]}</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

    }

}
