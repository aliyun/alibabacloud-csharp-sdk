// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ChangeVisibilityModelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data portal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>The IDs of the leaf node menus in the data portal.</para>
        /// <list type="bullet">
        /// <item><description>You can specify multiple IDs. Separate multiple IDs with commas (,). A maximum of 100 IDs can be modified at a time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54kqgoa****,pg1n135****</para>
        /// </summary>
        [NameInMap("MenuIds")]
        [Validation(Required=false)]
        public string MenuIds { get; set; }

        /// <summary>
        /// <para>Specifies whether the menus are visible only to authorized users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The menus are visible only to authorized users.</description></item>
        /// <item><description>false: The menus are visible to all users.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOnlyWithAccess")]
        [Validation(Required=false)]
        public bool? ShowOnlyWithAccess { get; set; }

    }

}
