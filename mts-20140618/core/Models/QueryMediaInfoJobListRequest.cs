// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaInfoJobListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the media information analysis jobs.</para>
        /// <list type="bullet">
        /// <item><description>You can query up to 10 jobs at a time. Separate multiple IDs with commas (,).</description></item>
        /// <item><description>You can obtain the details from the response parameters of the <a href="https://help.aliyun.com/document_detail/602827.html">SubmitMediaInfoJob</a> operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify the JobIds parameter, the <b>InvalidParameter</b> error code is returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23ca1d184c0e4341e5b665e2a12****</para>
        /// </summary>
        [NameInMap("MediaInfoJobIds")]
        [Validation(Required=false)]
        public string MediaInfoJobIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
