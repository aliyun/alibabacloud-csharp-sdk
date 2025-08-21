// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreloadRegionSDGRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the destination nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>An array that consists of queried namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The number of redundant replicas to support rapid deployment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RedundantNum")]
        [Validation(Required=false)]
        public int? RedundantNum { get; set; }

        /// <summary>
        /// <para>The ID of the SDG for which data is preloaded.</para>
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
