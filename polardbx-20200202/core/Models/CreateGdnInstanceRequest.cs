// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateGdnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FASTJSON 2.0.x has been released, faster and more secure, recommend you upgrade.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GdnMode")]
        [Validation(Required=false)]
        public string GdnMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RplConflictStrategy")]
        [Validation(Required=false)]
        public string RplConflictStrategy { get; set; }

        [NameInMap("RplDmlStrategy")]
        [Validation(Required=false)]
        public string RplDmlStrategy { get; set; }

        [NameInMap("RplSyncDdl")]
        [Validation(Required=false)]
        public bool? RplSyncDdl { get; set; }

    }

}
