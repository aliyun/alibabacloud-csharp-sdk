// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartReverseWriterRequest : TeaModel {
        /// <summary>
        /// <para>The offset of the Incremental Write module. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. </para>
        /// <remarks>
        /// <para>The default value is the offset that is automatically saved by DTS when the task is paused.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1695613785</para>
        /// </summary>
        [NameInMap("CheckPoint")]
        [Validation(Required=false)]
        public string CheckPoint { get; set; }

        /// <summary>
        /// <para>The ID of the reverse task that was created by calling the CreateReverseDtsJob operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n99m9jx822k****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
