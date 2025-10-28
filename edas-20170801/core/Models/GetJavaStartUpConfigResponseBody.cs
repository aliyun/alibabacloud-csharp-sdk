// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetJavaStartUpConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The configuration of Java startup parameters.</para>
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public GetJavaStartUpConfigResponseBodyJavaStartUpConfig JavaStartUpConfig { get; set; }
        public class GetJavaStartUpConfigResponseBodyJavaStartUpConfig : TeaModel {
            /// <summary>
            /// <para>The displayed startup parameter configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-Xms512m</para>
            /// </summary>
            [NameInMap("OriginalConfigs")]
            [Validation(Required=false)]
            public string OriginalConfigs { get; set; }

            /// <summary>
            /// <para>The effective startup parameter configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-Xms512m</para>
            /// </summary>
            [NameInMap("StartUpArgs")]
            [Validation(Required=false)]
            public string StartUpArgs { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4823-bhjf-23u4-eiufh</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
