// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ExtendImageStyleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtendImageStyleResponseBodyData Data { get; set; }
        public class ExtendImageStyleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MajorUrl")]
            [Validation(Required=false)]
            public string MajorUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://luban-vgd-invi.oss-cn-hangzhou.aliyuncs.com/upload/result_/2019-9-26/invi__015694889247201016812_spCq4n.jpg?Expires=1569492524&OSSAccessKeyId=LTAI4Fc5SVvzUQ19K1Cz****&Signature=uOEP8gKvdgPtDcrXxRz1v37dsT">http://luban-vgd-invi.oss-cn-hangzhou.aliyuncs.com/upload/result_/2019-9-26/invi__015694889247201016812_spCq4n.jpg?Expires=1569492524&amp;OSSAccessKeyId=LTAI4Fc5SVvzUQ19K1Cz****&amp;Signature=uOEP8gKvdgPtDcrXxRz1v37dsT</a>****</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F1ABC965-2612-4680-9DE3-B5C77434B9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
