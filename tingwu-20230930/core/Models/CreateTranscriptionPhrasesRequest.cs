// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTranscriptionPhrasesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>custom fruit phrases list</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fruit_phrase</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;苹果&quot;:3,&quot;西瓜&quot;:3}</para>
        /// </summary>
        [NameInMap("WordWeights")]
        [Validation(Required=false)]
        public string WordWeights { get; set; }

    }

}
