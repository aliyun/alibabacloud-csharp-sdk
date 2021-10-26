// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetWorkbenchTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("root")]
        [Validation(Required=false)]
        public GetWorkbenchTokenResponseBodyRoot Root { get; set; }
        public class GetWorkbenchTokenResponseBodyRoot : TeaModel {
            [NameInMap("instanceLoginView")]
            [Validation(Required=false)]
            public GetWorkbenchTokenResponseBodyRootInstanceLoginView InstanceLoginView { get; set; }
            public class GetWorkbenchTokenResponseBodyRootInstanceLoginView : TeaModel {
                [NameInMap("baseViewUrl")]
                [Validation(Required=false)]
                public string BaseViewUrl { get; set; }

                [NameInMap("defaultViewUrl")]
                [Validation(Required=false)]
                public string DefaultViewUrl { get; set; }

                [NameInMap("fileTreeViewUrl")]
                [Validation(Required=false)]
                public string FileTreeViewUrl { get; set; }

                [NameInMap("rdpViewUrl")]
                [Validation(Required=false)]
                public string RdpViewUrl { get; set; }

                [NameInMap("terminalViewUrl")]
                [Validation(Required=false)]
                public string TerminalViewUrl { get; set; }

                [NameInMap("viewName")]
                [Validation(Required=false)]
                public string ViewName { get; set; }

            }
        };

    }

}
