// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateContainerClusterRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-000**************134</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description ack pv backup</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack_pv_backup_location</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Network type, with possible values including:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC</b>: Classic Network.</description></item>
        /// <item><description><b>VPC</b>: Virtual Private Cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>Whether to regenerate the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenewToken")]
        [Validation(Required=false)]
        public bool? RenewToken { get; set; }

    }

}
