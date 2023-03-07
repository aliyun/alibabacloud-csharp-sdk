// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInstalledSoftwareResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of installed software.
        /// </summary>
        [NameInMap("SoftwareList")]
        [Validation(Required=false)]
        public ListInstalledSoftwareResponseBodySoftwareList SoftwareList { get; set; }
        public class ListInstalledSoftwareResponseBodySoftwareList : TeaModel {
            [NameInMap("SoftwareList")]
            [Validation(Required=false)]
            public List<ListInstalledSoftwareResponseBodySoftwareListSoftwareList> SoftwareList { get; set; }
            public class ListInstalledSoftwareResponseBodySoftwareListSoftwareList : TeaModel {
                /// <summary>
                /// The ID of the software.
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

                /// <summary>
                /// The name of the software.
                /// </summary>
                [NameInMap("SoftwareName")]
                [Validation(Required=false)]
                public string SoftwareName { get; set; }

                /// <summary>
                /// The status of the software. Valid values:
                /// 
                /// *   Installing: The software is being installed.
                /// *   Installed: The software is installed.
                /// </summary>
                [NameInMap("SoftwareStatus")]
                [Validation(Required=false)]
                public string SoftwareStatus { get; set; }

                /// <summary>
                /// The version of the software.
                /// </summary>
                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

            }

        }

    }

}
