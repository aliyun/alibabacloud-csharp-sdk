// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetRectifyFlowRequest : TeaModel {
        /// <summary>
        /// <para>The business request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GetQuery")]
        [Validation(Required=false)]
        public GetRectifyFlowRequestGetQuery GetQuery { get; set; }
        public class GetRectifyFlowRequestGetQuery : TeaModel {
            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6500387</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of items per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9919509</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The ID of the rectification process.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>442777862946</para>
            /// </summary>
            [NameInMap("RectifyId")]
            [Validation(Required=false)]
            public long? RectifyId { get; set; }

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
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
