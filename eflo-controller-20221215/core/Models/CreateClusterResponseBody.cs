// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i116913051663373010974</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C683243-7915-57FB-9570-A2932C1C0F78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i159809891662373011015</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
