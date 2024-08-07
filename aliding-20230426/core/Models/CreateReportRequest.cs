// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateReportRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<CreateReportRequestContents> Contents { get; set; }
        public class CreateReportRequestContents : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdFrom")]
        [Validation(Required=false)]
        public string DdFrom { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateReportRequestTenantContext TenantContext { get; set; }
        public class CreateReportRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ToChat")]
        [Validation(Required=false)]
        public bool? ToChat { get; set; }

        [NameInMap("ToCids")]
        [Validation(Required=false)]
        public List<string> ToCids { get; set; }

        [NameInMap("ToUserids")]
        [Validation(Required=false)]
        public List<string> ToUserids { get; set; }

    }

}
