// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateApplicationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1332695887xxxxxx</para>
        /// </summary>
        [NameInMap("creatorAccountId")]
        [Validation(Required=false)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>应用描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00.000+00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC93CE1A-8D7A-13A9-8306-7465DE2E5C0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
