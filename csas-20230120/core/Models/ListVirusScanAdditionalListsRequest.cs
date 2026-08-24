// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanAdditionalListsRequest : TeaModel {
        [NameInMap("AdditionalTypes")]
        [Validation(Required=false)]
        public List<string> AdditionalTypes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>.tmp</para>
        /// </summary>
        [NameInMap("ListDetail")]
        [Validation(Required=false)]
        public string ListDetail { get; set; }

        [NameInMap("ListIds")]
        [Validation(Required=false)]
        public List<string> ListIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Whitelist</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

    }

}
