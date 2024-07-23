// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateParamsResponseBody : TeaModel {
        [NameInMap("ParamList")]
        [Validation(Required=false)]
        public List<GetTemplateParamsResponseBodyParamList> ParamList { get; set; }
        public class GetTemplateParamsResponseBodyParamList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>video1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("MediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>419c8741c1b4325f035b</b></b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
