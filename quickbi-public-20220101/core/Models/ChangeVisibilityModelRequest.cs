// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ChangeVisibilityModelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the BI portal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d173abb53e84c8ca7495429163b****</para>
        /// </summary>
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        /// <summary>
        /// <para>The menu ID of the BI portal leaf node.</para>
        /// <list type="bullet">
        /// <item><description>The directory menu cannot be authorized.</description></item>
        /// <item><description>You can upload multiple parameters at a time. Separate multiple IDs with commas (,). The maximum number of parameters that can be modified at a time is 100.</description></item>
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
        /// <para>Whether only authorization is visible. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only the authorization is visible.</description></item>
        /// <item><description>false: Both are visible.</description></item>
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
