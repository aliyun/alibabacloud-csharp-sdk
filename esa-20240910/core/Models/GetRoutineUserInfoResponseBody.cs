// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routines.</para>
        /// </summary>
        [NameInMap("Routines")]
        [Validation(Required=false)]
        public List<GetRoutineUserInfoResponseBodyRoutines> Routines { get; set; }
        public class GetRoutineUserInfoResponseBodyRoutines : TeaModel {
            /// <summary>
            /// <para>The time when the routine was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-11T01:23:02.883361712Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The routine description, which is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWRpdCByb3V0aW5lIGNvbmZpZyBkZXNjcmlwdGlvbg</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The routine name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-routine1</para>
            /// </summary>
            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

        }

        /// <summary>
        /// <para>The subdomains.</para>
        /// </summary>
        [NameInMap("Subdomains")]
        [Validation(Required=false)]
        public List<string> Subdomains { get; set; }

    }

}
