// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAttachedMediaRequest : TeaModel {
        /// <summary>
        /// <para>The auxiliary media asset IDs.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). A maximum of 20 IDs are supported.</description></item>
        /// <item><description>The IDs are returned after you call the <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> operation to obtain the upload URL and credential for auxiliary media assets.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8bc8e94fe4e55abde85718****,eb186180e989dd56****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
