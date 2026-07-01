// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteYikeAssetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a logical delete or a permanent delete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Performs a logical delete. This action moves the media asset to the recycle bin and retains its associated file.</para>
        /// </description></item>
        /// <item><description><para>false: Performs a permanent delete. This action deletes both the media asset information and the associated file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogicDelete")]
        [Validation(Required=false)]
        public bool? LogicDelete { get; set; }

        /// <summary>
        /// <para>A comma-separated list of media asset IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b>,<b><b>15d4a4b0448391508f2cb486</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
