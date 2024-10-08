// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurgeCachesRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public PurgeCachesRequestContent Content { get; set; }
        public class PurgeCachesRequestContent : TeaModel {
            [NameInMap("CacheTags")]
            [Validation(Required=false)]
            public List<string> CacheTags { get; set; }

            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<object> Files { get; set; }

            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            [NameInMap("IgnoreParams")]
            [Validation(Required=false)]
            public List<string> IgnoreParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PurgeAll")]
            [Validation(Required=false)]
            public bool? PurgeAll { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EdgeComputePurge")]
        [Validation(Required=false)]
        public bool? EdgeComputePurge { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
