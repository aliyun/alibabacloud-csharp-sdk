// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartTransferStreamRequest : TeaModel {
        /// <summary>
        /// <para>Stream ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323*****998-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the transcoding rule (a transcoding template must be bound first).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sd</para>
        /// </summary>
        [NameInMap("Transcode")]
        [Validation(Required=false)]
        public string Transcode { get; set; }

        /// <summary>
        /// <para>The destination address for stream forwarding.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
