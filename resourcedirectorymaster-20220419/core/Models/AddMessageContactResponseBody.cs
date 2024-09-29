// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AddMessageContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the contact.</para>
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public AddMessageContactResponseBodyContact Contact { get; set; }
        public class AddMessageContactResponseBodyContact : TeaModel {
            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-qL4HqKONzOM7****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The time when the contact was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-27 17:19:21</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DFCE4C9-04A9-4C83-BB14-FE791275EC53</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
