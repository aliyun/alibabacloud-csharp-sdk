// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SyncDingTypeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_DING</para>
        /// </summary>
        [NameInMap("DingType")]
        [Validation(Required=false)]
        public string DingType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("IsDimission")]
        [Validation(Required=false)]
        public string IsDimission { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antding</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SyncDingTypeRequestTenantContext TenantContext { get; set; }
        public class SyncDingTypeRequestTenantContext : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>012345</para>
        /// </summary>
        [NameInMap("WorkNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
