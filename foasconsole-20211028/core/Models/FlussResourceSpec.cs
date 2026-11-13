// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class FlussResourceSpec : TeaModel {
        /// <summary>
        /// <para>The disk capacity of a single TabletServer node, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("DiskSizeInGB")]
        [Validation(Required=false)]
        public long? DiskSizeInGB { get; set; }

        /// <summary>
        /// <para>The node specifications of the TabletServer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4 RCU</para>
        /// </summary>
        [NameInMap("SlaveModel")]
        [Validation(Required=false)]
        public string SlaveModel { get; set; }

        /// <summary>
        /// <para>The number of TabletServer nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SlaveNum")]
        [Validation(Required=false)]
        public long? SlaveNum { get; set; }

        /// <summary>
        /// <para>The maximum number of elastic compute resources for the lake-stream synchronization service, in CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TieringPostCu")]
        [Validation(Required=false)]
        public long? TieringPostCu { get; set; }

        /// <summary>
        /// <para>The baseline resource count of the lake-stream synchronization service, in CUs.</para>
        /// </summary>
        [NameInMap("TieringPreCu")]
        [Validation(Required=false)]
        public long? TieringPreCu { get; set; }

    }

}
