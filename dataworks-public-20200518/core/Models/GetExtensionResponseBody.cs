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
            /// The list of extension points.
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
            /// The URL of the extension details page, on which users can view the details of the process blocked by the extension.
            /// </summary>
            [NameInMap("DetailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            /// <summary>
            /// The list of event types.
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
            /// The URL of the help documentation of the extension.
            /// </summary>
            [NameInMap("HelpDocUrl")]
            [Validation(Required=false)]
            public string HelpDocUrl { get; set; }

            /// <summary>
            /// The options defined for the extension.
            /// </summary>
            [NameInMap("OptionSetting")]
            [Validation(Required=false)]
            public string OptionSetting { get; set; }

            /// <summary>
            /// The parameter settings of the extension. For more information, see [Configure extension parameters](https://help.aliyun.com/document_detail/405354.html).
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// The workspace for testing. If the extension is being tested, the extension can be used only in the workspace for testing.
            /// </summary>
            [NameInMap("ProjectTesting")]
            [Validation(Required=false)]
            public long? ProjectTesting { get; set; }

            /// <summary>
            /// The state of the extension. 0: Testing, 1: Publishing, 3: Disabled, 4: Processing, 5: Approved, 6: Approve Failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the request ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
