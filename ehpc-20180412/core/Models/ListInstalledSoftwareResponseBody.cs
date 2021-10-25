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
                public string SoftwareId { get; set; }
                public string SoftwareStatus { get; set; }
                public string SoftwareVersion { get; set; }
                public string SoftwareName { get; set; }
            }
        };

    }

}
