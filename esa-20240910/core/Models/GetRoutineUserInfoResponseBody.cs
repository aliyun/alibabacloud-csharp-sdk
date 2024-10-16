// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routines")]
        [Validation(Required=false)]
        public List<GetRoutineUserInfoResponseBodyRoutines> Routines { get; set; }
        public class GetRoutineUserInfoResponseBodyRoutines : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

        }

        [NameInMap("Subdomains")]
        [Validation(Required=false)]
        public List<string> Subdomains { get; set; }

    }

}
