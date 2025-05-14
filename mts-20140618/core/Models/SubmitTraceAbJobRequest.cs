// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitTraceAbJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qh6OdgIMcliQSI1fReOw****</para>
        /// </summary>
        [NameInMap("CipherBase64ed")]
        [Validation(Required=false)]
        public string CipherBase64ed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;ivison-test&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;test.mp4&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;ivison-test&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Dir&quot;:&quot;out/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/video/test.mp4">http://www.example.com/video/test.mp4</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
