// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the deployment task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud: multi-cloud deployment task.</para>
        /// </description></item>
        /// <item><description><para>user: cloud service deployment task. This type of task does not support Elastic Compute Service (ECS) instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The status of the deployment task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>success</para>
        /// </description></item>
        /// <item><description><para>pending</para>
        /// </description></item>
        /// <item><description><para>scheduling</para>
        /// </description></item>
        /// <item><description><para>processing</para>
        /// </description></item>
        /// <item><description><para>error</para>
        /// </description></item>
        /// <item><description><para>editing</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
