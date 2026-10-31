// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The data source deletion request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteDataSourceRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteDataSourceRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The deletion mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: Deletes only the data source in the development environment.</description></item>
            /// <item><description>DEV_PROD: Deletes the data sources in both the development and production environments.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The ID of the data source in the production environment.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13121</para>
            /// </summary>
            [NameInMap("ProdDataSourceId")]
            [Validation(Required=false)]
            public long? ProdDataSourceId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
