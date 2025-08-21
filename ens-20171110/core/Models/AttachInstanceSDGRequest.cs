// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachInstanceSDGRequest : TeaModel {
        [NameInMap("DiskAccessProtocol")]
        [Validation(Required=false)]
        public string DiskAccessProtocol { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("LoadOpt")]
        [Validation(Required=false)]
        public AttachInstanceSDGRequestLoadOpt LoadOpt { get; set; }
        public class AttachInstanceSDGRequestLoadOpt : TeaModel {
            [NameInMap("BlockRwSplit")]
            [Validation(Required=false)]
            public bool? BlockRwSplit { get; set; }

            [NameInMap("BlockRwSplitSize")]
            [Validation(Required=false)]
            public int? BlockRwSplitSize { get; set; }

            [NameInMap("Cache")]
            [Validation(Required=false)]
            public bool? Cache { get; set; }

            [NameInMap("CacheSize")]
            [Validation(Required=false)]
            public int? CacheSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the SDG.</para>
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
