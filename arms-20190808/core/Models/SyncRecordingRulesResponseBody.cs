// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SyncRecordingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;data&quot;:[         &quot;c06ca68cd16f14f52bb07772eda***&quot;,         &quot;c33dd70a0ac184c1b879d807ab2***&quot;,         &quot;c384cf7e4dcb543e6ac8c7d4dd3***&quot;,         &quot;ce30f833bc4a04a56a06b070319***&quot;     ],     &quot;message&quot;:&quot;设置RecordingRule失败的clusterIds&quot;,     &quot;success&quot;:true }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The message returned with the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
