// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class DeleteYikeAssetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the media asset information and files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): logical deletion. The media asset is moved to the recycle bin, and the files are retained.</description></item>
        /// <item><description>false: deletes the media asset information and files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogicDelete")]
        [Validation(Required=false)]
        public bool? LogicDelete { get; set; }

        /// <summary>
        /// <para>The ICE media asset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b>,<b><b>15d4a4b0448391508f2cb486</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
