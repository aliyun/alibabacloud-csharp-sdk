// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnloadRegionSDGRequest : TeaModel {
        /// <summary>
        /// <para>The destination nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>Deletes the shared data group (SDG) ID of the preloaded data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxx</para>
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
