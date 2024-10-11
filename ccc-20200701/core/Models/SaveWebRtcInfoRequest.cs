// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SaveWebRtcInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e13c9740-1e37-123b-21b6-00163e352f9</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;media_source&quot;:{},&quot;remote_inbound_rtp&quot;:{},&quot;outbound_rtp&quot;:{},&quot;inbound_rtp&quot;:{},&quot;remote_outbound_rtp&quot;:{},&quot;candidate&quot;:{},&quot;basic&quot;:{&quot;callId&quot;:&quot;e13c9740-1e37-123b-21b6-00163e352f9&quot;,&quot;timestamp&quot;:&quot;1647262108395&quot;,&quot;callStartTime&quot;:&quot;1647262108393&quot;,&quot;uid&quot;:&quot;user-test&quot;,&quot;access_point&quot;:&quot;shanghai&quot;,&quot;browser&quot;:&quot;90&quot;,&quot;ip&quot;:&quot;127.0.0.1&quot;}}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-b8b0ca63-330c-4e65-8ae3-9de2c7ce7683</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
