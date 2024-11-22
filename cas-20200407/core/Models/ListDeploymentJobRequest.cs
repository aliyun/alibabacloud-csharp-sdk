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
        /// <item><description>cloud: multi-cloud deployment task.</description></item>
        /// <item><description>user: cloud service deployment task. This type of task does not support Elastic Compute Service (ECS) instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The number of certificates per page. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The status of the deployment task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success</description></item>
        /// <item><description>pending</description></item>
        /// <item><description>scheduling</description></item>
        /// <item><description>processing</description></item>
        /// <item><description>error</description></item>
        /// <item><description>editing</description></item>
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
