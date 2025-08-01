// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectDashboardAccountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxpassword</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxuser</para>
        /// </summary>
        [NameInMap("DashboardUsername")]
        [Validation(Required=false)]
        public string DashboardUsername { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sbp-twmoe9bakow</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>supabase_prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
