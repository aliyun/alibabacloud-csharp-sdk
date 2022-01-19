/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class CreateConsoleAccessWhiteListRequest : TeaModel {
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        [NameInMap("InstanceInfoList")]
        [Validation(Required=false)]
        public string InstanceInfoList { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LiveTime")]
        [Validation(Required=false)]
        public int? LiveTime { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public int? WhiteListType { get; set; }

    }

}
