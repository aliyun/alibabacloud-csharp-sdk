// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceClassRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public long? ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum capacity for auto scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public long? ScaleMin { get; set; }

    }

}
