// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateRangeRequest : TeaModel {
        [NameInMap("BackgroundColors")]
        [Validation(Required=false)]
        public List<List<string>> BackgroundColors { get; set; }

        [NameInMap("Hyperlinks")]
        [Validation(Required=false)]
        public List<List<UpdateRangeRequestHyperlinks>> Hyperlinks { get; set; }
        public class UpdateRangeRequestHyperlinks : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("NumberFormat")]
        [Validation(Required=false)]
        public string NumberFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RangeAddress")]
        [Validation(Required=false)]
        public string RangeAddress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SheetId")]
        [Validation(Required=false)]
        public string SheetId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateRangeRequestTenantContext TenantContext { get; set; }
        public class UpdateRangeRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkbookId")]
        [Validation(Required=false)]
        public string WorkbookId { get; set; }

    }

}
