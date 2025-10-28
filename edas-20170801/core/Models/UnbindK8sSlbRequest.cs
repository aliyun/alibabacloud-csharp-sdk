// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UnbindK8sSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-</b></b>-a286-781659d9f54c</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. You can call the GetK8sCluster operation to query the cluster ID. For more information, see <a href="https://help.aliyun.com/document_detail/181437.html">GetK8sCluster</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>712082c3-<b><b>-</b></b>-9217-a947b5cde6ee</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2d4ab12666544a479cdd0711a97****</para>
        /// </summary>
        [NameInMap("SlbName")]
        [Validation(Required=false)]
        public string SlbName { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet-facing SLB instance</description></item>
        /// <item><description><b>intranet</b>: internal-facing SLB instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
