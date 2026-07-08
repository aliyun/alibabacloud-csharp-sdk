// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateDeploymentJobStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The desired status of the deployment task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>pending</para>
        /// </description></item>
        /// <item><description><para>scheduling</para>
        /// </description></item>
        /// <item><description><para>editing</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>editing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
