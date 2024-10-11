// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAttachedMediaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the auxiliary media asset that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). You can specify up to 20 IDs.</description></item>
        /// <item><description>You can obtain the ID from the response to the <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> operation that you call to obtain the upload URL and credential.</description></item>
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
