// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateProhibitedTagResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D3BCF94-7F83-559E-82D9-C891BBB32FC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The prohibited software tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public UpdateProhibitedTagResponseBodyTag Tag { get; set; }
        public class UpdateProhibitedTagResponseBodyTag : TeaModel {
            /// <summary>
            /// <para>The creation time of the prohibited software tag, in the yyyy-MM-dd HH:mm:ss format. The time is displayed in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-05 10:20:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test constraints</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-d730092d87ec****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
