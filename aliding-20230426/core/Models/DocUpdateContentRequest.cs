// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DocUpdateContentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4j6OJzVEG4jJO3p8</para>
        /// </summary>
        [NameInMap("DocKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public DocUpdateContentRequestTenantContext TenantContext { get; set; }
        public class DocUpdateContentRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
