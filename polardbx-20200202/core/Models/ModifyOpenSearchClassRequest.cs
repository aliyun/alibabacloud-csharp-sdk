// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyOpenSearchClassRequest : TeaModel {
        /// <summary>
        /// <para>The target disk size per node, in GB. If this parameter is not specified, the current disk size is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DBInstanceDiskSize")]
        [Validation(Required=false)]
        public int? DBInstanceDiskSize { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-spsil01pww4hfz</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The node specifications code for PolarDBX Search data nodes. This parameter is required. The active node specifications depend on the region and sales configuration, and must differ from the current node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opensearch.sn2ne.large.1</para>
        /// </summary>
        [NameInMap("SearchClassCode")]
        [Validation(Required=false)]
        public string SearchClassCode { get; set; }

    }

}
