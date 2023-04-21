// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesResponseBody : TeaModel {
        /// <summary>
        /// Details about cloud desktops.
        /// </summary>
        [NameInMap("DesktopItems")]
        [Validation(Required=false)]
        public List<DescribeDesktopIdsByVulNamesResponseBodyDesktopItems> DesktopItems { get; set; }
        public class DescribeDesktopIdsByVulNamesResponseBodyDesktopItems : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
