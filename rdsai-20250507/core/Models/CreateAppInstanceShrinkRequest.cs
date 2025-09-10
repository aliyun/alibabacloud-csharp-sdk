// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateAppInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-supabase</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DBInstanceConfig")]
        [Validation(Required=false)]
        public string DBInstanceConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("DashboardUsername")]
        [Validation(Required=false)]
        public string DashboardUsername { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_Password</para>
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PublicNetworkAccessEnabled")]
        [Validation(Required=false)]
        public bool? PublicNetworkAccessEnabled { get; set; }

        [NameInMap("RAGEnabled")]
        [Validation(Required=false)]
        public bool? RAGEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-9dp2hkpm22gxscfgy****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
