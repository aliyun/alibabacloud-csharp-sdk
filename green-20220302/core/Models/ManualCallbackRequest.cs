// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The channel field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ant</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The checksum.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Result\&quot;: [{\&quot;Confidence\&quot;: 100.0, \&quot;CustomizedHit\&quot;: [{\&quot;KeyWords\&quot;: u\&quot;\u4fdd\u969c,\u6700\u5927,\u9ad8\u7ea7\&quot;, \&quot;LibName\&quot;: u\&quot;\u4f18\u8def\u654f\u611f\u8bcd\&quot;}], \&quot;Label\&quot;: \&quot;customized\&quot;}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the platform request. This ID is used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0963D30-BAB4-562F-9ED0-7A23AEC51C7C</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

    }

}
