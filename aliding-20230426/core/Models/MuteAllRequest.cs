// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class MuteAllRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceMute")]
        [Validation(Required=false)]
        public bool? ForceMute { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public MuteAllRequestTenantContext TenantContext { get; set; }
        public class MuteAllRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mute</para>
        /// </summary>
        [NameInMap("muteAction")]
        [Validation(Required=false)]
        public string MuteAction { get; set; }

    }

}
