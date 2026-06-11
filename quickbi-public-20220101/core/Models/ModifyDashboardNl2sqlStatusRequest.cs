// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ModifyDashboardNl2sqlStatusRequest : TeaModel {
        /// <summary>
        /// <para>An array of dashboard IDs. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>Notice: The number of IDs cannot exceed 50.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asda,sadaf</para>
        /// </summary>
        [NameInMap("DashboardIds")]
        [Validation(Required=false)]
        public string DashboardIds { get; set; }

        /// <summary>
        /// <para>The status identifier. 0 indicates disabled and 1 indicates enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
