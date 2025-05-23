// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class ModifyVirtualWareHouseConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigChanges")]
        [Validation(Required=false)]
        public List<ModifyVirtualWareHouseConfigRequestConfigChanges> ConfigChanges { get; set; }
        public class ModifyVirtualWareHouseConfigRequestConfigChanges : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keep_alive_timeout</para>
            /// </summary>
            [NameInMap("ConfigFullPath")]
            [Validation(Required=false)]
            public string ConfigFullPath { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cc-bp1qx68m06981****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vw-uf62965t8lt50****</para>
        /// </summary>
        [NameInMap("VirtualWareHouseId")]
        [Validation(Required=false)]
        public string VirtualWareHouseId { get; set; }

    }

}
