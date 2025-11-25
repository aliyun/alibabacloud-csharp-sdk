// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ResetInstancePasswordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
