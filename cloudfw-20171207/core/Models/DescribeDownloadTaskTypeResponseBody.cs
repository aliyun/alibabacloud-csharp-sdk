// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDownloadTaskTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B835494C-D093-5524-BBDE-BD272077B40E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task types.</para>
        /// </summary>
        [NameInMap("TaskTypeArray")]
        [Validation(Required=false)]
        public List<DescribeDownloadTaskTypeResponseBodyTaskTypeArray> TaskTypeArray { get; set; }
        public class DescribeDownloadTaskTypeResponseBodyTaskTypeArray : TeaModel {
            /// <summary>
            /// <para>The name of the task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internet Boundary Firewall Assets</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetFirewallAsset</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
