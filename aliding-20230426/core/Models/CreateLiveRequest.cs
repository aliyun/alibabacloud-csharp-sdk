// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateLiveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://sss/sss">http://sss/sss</a></para>
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个直播</para>
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698596800000</para>
        /// </summary>
        [NameInMap("PreEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1691596800000</para>
        /// </summary>
        [NameInMap("PreStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PublicType")]
        [Validation(Required=false)]
        public long? PublicType { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateLiveRequestTenantContext TenantContext { get; set; }
        public class CreateLiveRequestTenantContext : TeaModel {
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
        /// <para>标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
