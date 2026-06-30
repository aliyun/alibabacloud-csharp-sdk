// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateMultiDimTableRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BaseId")]
        [Validation(Required=false)]
        public string BaseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<UpdateMultiDimTableRecordsRequestRecordIds> RecordIds { get; set; }
        public class UpdateMultiDimTableRecordsRequestRecordIds : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SheetIdOrName")]
        [Validation(Required=false)]
        public string SheetIdOrName { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateMultiDimTableRecordsRequestTenantContext TenantContext { get; set; }
        public class UpdateMultiDimTableRecordsRequestTenantContext : TeaModel {
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
