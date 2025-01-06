// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeExportProgressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://ssml-test.oss-cn-shanghai.aliyuncs.com/key">http://ssml-test.oss-cn-shanghai.aliyuncs.com/key</a></para>
        /// </summary>
        [NameInMap("FileHttpUrl")]
        [Validation(Required=false)]
        public string FileHttpUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b19af5ce5314ac08108d1b33fe20e15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
