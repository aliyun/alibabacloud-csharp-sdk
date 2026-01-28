// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class ExecuteComponentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>doRequest</para>
        /// </summary>
        [NameInMap("ComponentActionName")]
        [Validation(Required=false)]
        public string ComponentActionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1C5F11E9-<b><b>-51F0-</b></b>-43BB312A0557</para>
        /// </summary>
        [NameInMap("ComponentAssetUuid")]
        [Validation(Required=false)]
        public string ComponentAssetUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ComponentInput")]
        [Validation(Required=false)]
        public string ComponentInput { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>node1</para>
        /// </summary>
        [NameInMap("PlayBookNodeName")]
        [Validation(Required=false)]
        public string PlayBookNodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ac343acc-1a61-4084-9a1cxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
