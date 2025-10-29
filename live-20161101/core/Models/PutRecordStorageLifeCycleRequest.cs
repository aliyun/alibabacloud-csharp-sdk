// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class PutRecordStorageLifeCycleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream-xxx</para>
        /// </summary>
        [NameInMap("StreamIds")]
        [Validation(Required=false)]
        public List<string> StreamIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1095days</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758621407</para>
        /// </summary>
        [NameInMap("UnixTimestamp")]
        [Validation(Required=false)]
        public long? UnixTimestamp { get; set; }

    }

}
