// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleTemplatesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions for the scheduling template list. This is a JSON object that supports keyword search and pagination.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListScheduleTemplatesCommand")]
        [Validation(Required=false)]
        public string ListScheduleTemplatesCommandShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID, which indicates the tenant for the current operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
