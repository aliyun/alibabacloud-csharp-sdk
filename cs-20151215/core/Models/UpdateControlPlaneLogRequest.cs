// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateControlPlaneLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>162981*****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public string Aliuid { get; set; }

        /// <summary>
        /// <para>The control plane components for which you want to enable log collection.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<string> Components { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service Project that you want to use to store the logs of control plane components.</para>
        /// <para>Default value: k8s-log-$Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-c5b5e80b0b64a4bf6939d2d8fbbc5****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("log_project")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        /// <summary>
        /// <para>The retention period of the log data stored in the Logstore. Valid values: 1 to 3000. Unit: days.</para>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("log_ttl")]
        [Validation(Required=false)]
        public string LogTtl { get; set; }

    }

}
