// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class SearchPunishEventsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("BussinessCodes")]
        [Validation(Required=false)]
        public List<string> BussinessCodes { get; set; }

        [NameInMap("CaseCodes")]
        [Validation(Required=false)]
        public List<string> CaseCodes { get; set; }

        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public List<string> EventCodes { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
