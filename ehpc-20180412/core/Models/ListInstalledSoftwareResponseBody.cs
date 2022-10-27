// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInstalledSoftwareResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SoftwareList")]
        [Validation(Required=false)]
        public ListInstalledSoftwareResponseBodySoftwareList SoftwareList { get; set; }
        public class ListInstalledSoftwareResponseBodySoftwareList : TeaModel {
            [NameInMap("SoftwareList")]
            [Validation(Required=false)]
            public List<ListInstalledSoftwareResponseBodySoftwareListSoftwareList> SoftwareList { get; set; }
            public class ListInstalledSoftwareResponseBodySoftwareListSoftwareList : TeaModel {
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

                [NameInMap("SoftwareName")]
                [Validation(Required=false)]
                public string SoftwareName { get; set; }

                [NameInMap("SoftwareStatus")]
                [Validation(Required=false)]
                public string SoftwareStatus { get; set; }

                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

            }

        }

    }

}
