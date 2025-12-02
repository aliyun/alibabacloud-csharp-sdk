// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class DeleteComponentAssetRequest : TeaModel {
        /// <summary>
        /// <para>Asset UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C5F11E9-<b><b>-51F0-</b></b>-43BB312A0557</para>
        /// </summary>
        [NameInMap("ComponentAssetUuid")]
        [Validation(Required=false)]
        public string ComponentAssetUuid { get; set; }

        /// <summary>
        /// <para>Set the language type for requests and received messages, default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Resource directory member account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
