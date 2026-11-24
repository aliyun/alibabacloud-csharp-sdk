// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedTagResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7F30ABA-67BD-537D-A516-8DA20DA1F28C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The prohibited software tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public CreateProhibitedTagResponseBodyTag Tag { get; set; }
        public class CreateProhibitedTagResponseBodyTag : TeaModel {
            /// <summary>
            /// <para>The time when the prohibited software tag was created. The time is in the yyyy-MM-dd HH:mm:ss format and uses the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-19 10:24:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template create get delete</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_37bf6a18</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-4a4046838f77****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
