// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8b96ade0-0a07-****-af9d-5ed83640d076</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the cluster ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: specifies the ID of the cluster in Enterprise Distributed Application Service (EDAS).</description></item>
        /// <item><description>1: specifies the ID of the ACK cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

    }

}
