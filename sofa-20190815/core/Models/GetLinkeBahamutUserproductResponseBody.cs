// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutUserproductResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutUserproductResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutUserproductResponseBodyResult : TeaModel {
            [NameInMap("Cat")]
            [Validation(Required=false)]
            public string Cat { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public bool? Fixed { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("IconTheme")]
            [Validation(Required=false)]
            public string IconTheme { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OpenBlank")]
            [Validation(Required=false)]
            public bool? OpenBlank { get; set; }

            [NameInMap("Show")]
            [Validation(Required=false)]
            public bool? Show { get; set; }

            [NameInMap("Sort")]
            [Validation(Required=false)]
            public long? Sort { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("Menus")]
            [Validation(Required=false)]
            public List<string> Menus { get; set; }

        }

    }

}
