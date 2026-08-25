// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyVirtualClusterRequest : TeaModel {
        /// <summary>
        /// <para>The primary cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-o2yg***-be</para>
        /// </summary>
        [NameInMap("ActiveClusterId")]
        [Validation(Required=false)]
        public string ActiveClusterId { get; set; }

        /// <summary>
        /// <para>The virtual cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-vcg-b****-be</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
        /// <para>The secondary cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-pu6y****-be</para>
        /// </summary>
        [NameInMap("StandbyClusterId")]
        [Validation(Required=false)]
        public string StandbyClusterId { get; set; }

    }

}
