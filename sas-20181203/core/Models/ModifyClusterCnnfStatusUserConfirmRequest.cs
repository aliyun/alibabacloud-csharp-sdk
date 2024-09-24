// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClusterCnnfStatusUserConfirmRequest : TeaModel {
        /// <summary>
        /// <para>The cluster IDs.</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to fix the blocking status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes</description></item>
        /// <item><description>false: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserConfirm")]
        [Validation(Required=false)]
        public bool? UserConfirm { get; set; }

    }

}
