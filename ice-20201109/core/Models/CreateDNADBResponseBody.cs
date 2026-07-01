// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateDNADBResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the DNA database.</para>
        /// </summary>
        [NameInMap("DBInfo")]
        [Validation(Required=false)]
        public CreateDNADBResponseBodyDBInfo DBInfo { get; set; }
        public class CreateDNADBResponseBodyDBInfo : TeaModel {
            /// <summary>
            /// <para>The DNA database ID. Save this ID for use in subsequent API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            /// <summary>
            /// <para>The description of the DNA database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个视频DNA库。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The DNA database model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Video</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The name of the DNA database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>After you create the database, its status is <c>offline</c> by default. The status automatically changes to <c>active</c> after the backend completes processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
