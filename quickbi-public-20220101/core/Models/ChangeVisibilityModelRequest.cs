// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ChangeVisibilityModelRequest : TeaModel {
        /// <summary>
        /// <para>The number of menus that are successfully modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
