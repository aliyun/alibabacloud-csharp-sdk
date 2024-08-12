// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTerminalRequest : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        [NameInMap("InManage")]
        [Validation(Required=false)]
        public bool? InManage { get; set; }

        [NameInMap("Ipv4")]
        [Validation(Required=false)]
        public string Ipv4 { get; set; }

        [NameInMap("LocationInfo")]
        [Validation(Required=false)]
        public string LocationInfo { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("SearchKeyword")]
        [Validation(Required=false)]
        public string SearchKeyword { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("TerminalGroupId")]
        [Validation(Required=false)]
        public string TerminalGroupId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
