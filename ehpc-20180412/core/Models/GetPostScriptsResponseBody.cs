// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetPostScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The post-installation scripts.</para>
        /// </summary>
        [NameInMap("PostInstallScripts")]
        [Validation(Required=false)]
        public List<GetPostScriptsResponseBodyPostInstallScripts> PostInstallScripts { get; set; }
        public class GetPostScriptsResponseBodyPostInstallScripts : TeaModel {
            /// <summary>
            /// <para>The parameter that is used to run the post-installation script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-h</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the post-installation script.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://bucket.oss-cn-shanghai.aliyuncs.com/postscript_examples.sh">https://bucket.oss-cn-shanghai.aliyuncs.com/postscript_examples.sh</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
