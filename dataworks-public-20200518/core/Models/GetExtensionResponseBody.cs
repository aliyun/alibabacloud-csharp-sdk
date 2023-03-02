// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetExtensionResponseBody : TeaModel {
        /// <summary>
        /// The details of the extension.
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public GetExtensionResponseBodyExtension Extension { get; set; }
        public class GetExtensionResponseBodyExtension : TeaModel {
            /// <summary>
            /// The extension point events.
            /// </summary>
            [NameInMap("BindEventList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionBindEventList> BindEventList { get; set; }
            public class GetExtensionResponseBodyExtensionBindEventList : TeaModel {
                /// <summary>
                /// The code of the extension point event.
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// The name of the extension point event.
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

            }

            /// <summary>
            /// The URL of the help document about the extension. You can visit the URL for the details of the extension.
            /// </summary>
            [NameInMap("DetailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            /// <summary>
            /// The types of the events.
            /// </summary>
            [NameInMap("EventCategoryList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionEventCategoryList> EventCategoryList { get; set; }
            public class GetExtensionResponseBodyExtensionEventCategoryList : TeaModel {
                /// <summary>
                /// The code of the event type.
                /// </summary>
                [NameInMap("CategoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                /// <summary>
                /// The name of the event type.
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

            }

            /// <summary>
            /// The unique code of the extension.
            /// </summary>
            [NameInMap("ExtensionCode")]
            [Validation(Required=false)]
            public string ExtensionCode { get; set; }

            /// <summary>
            /// The description of the extension.
            /// </summary>
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            /// <summary>
            /// The name of the extension.
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// The URL of the help document about the extension.
            /// </summary>
            [NameInMap("HelpDocUrl")]
            [Validation(Required=false)]
            public string HelpDocUrl { get; set; }

            /// <summary>
            /// The option settings of the extension.
            /// </summary>
            [NameInMap("OptionSetting")]
            [Validation(Required=false)]
            public string OptionSetting { get; set; }

            /// <summary>
            /// The parameter settings of the extension. For more information, visit https://www.alibabacloud.com/help/en/dataworks/latest/set-extension-parameters.
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// The workspace for testing. If the extension is in the testing state, the extension can be used only in the workspace for testing.
            /// </summary>
            [NameInMap("ProjectTesting")]
            [Validation(Required=false)]
            public long? ProjectTesting { get; set; }

            /// <summary>
            /// The state of the extension. 0: testing. 1: publishing. 3: disabled. 4: approving. 5: approved. 6: approval failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
