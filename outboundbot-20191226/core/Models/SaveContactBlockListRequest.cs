// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveContactBlockListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ContactBlockListList")]
        [Validation(Required=false)]
        public List<string> ContactBlockListList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ContactBlockListsJson")]
        [Validation(Required=false)]
        public string ContactBlockListsJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c3c92de8-e4bd-4db4-a962-50f8acce40bc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
