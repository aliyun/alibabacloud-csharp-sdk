// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StartCloudRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>speech</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>relative_right</para>
        /// </summary>
        [NameInMap("SmallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public StartCloudRecordRequestTenantContext TenantContext { get; set; }
        public class StartCloudRecordRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61289fxxx</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

    }

}
