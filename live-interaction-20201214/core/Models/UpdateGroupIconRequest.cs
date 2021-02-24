// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateGroupIconRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public UpdateGroupIconRequestRequestParams RequestParams { get; set; }
        public class UpdateGroupIconRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }
            [NameInMap("IconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }
        };

    }

}
