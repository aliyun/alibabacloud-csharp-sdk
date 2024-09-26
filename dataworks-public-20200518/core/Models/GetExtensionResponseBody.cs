// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetExtensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the extension.</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public GetExtensionResponseBodyExtension Extension { get; set; }
        public class GetExtensionResponseBodyExtension : TeaModel {
            /// <summary>
            /// <para>The list of extension points.</para>
            /// </summary>
            [NameInMap("BindEventList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionBindEventList> BindEventList { get; set; }
            public class GetExtensionResponseBodyExtensionBindEventList : TeaModel {
                /// <summary>
                /// <para>The code of the extension point event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>commit-file</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The name of the extension point event.</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

            }

            /// <summary>
            /// <para>The URL of the extension details page, on which users can view the details of the process blocked by the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com/">https://www.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("DetailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            /// <summary>
            /// <para>The list of event types.</para>
            /// </summary>
            [NameInMap("EventCategoryList")]
            [Validation(Required=false)]
            public List<GetExtensionResponseBodyExtensionEventCategoryList> EventCategoryList { get; set; }
            public class GetExtensionResponseBodyExtensionEventCategoryList : TeaModel {
                /// <summary>
                /// <para>The code of the event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file-change</para>
                /// </summary>
                [NameInMap("CategoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                /// <summary>
                /// <para>The name of the event type.</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

            }

            /// <summary>
            /// <para>The unique code of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ce4*********086da5</para>
            /// </summary>
            [NameInMap("ExtensionCode")]
            [Validation(Required=false)]
            public string ExtensionCode { get; set; }

            /// <summary>
            /// <para>The description of the extension.</para>
            /// </summary>
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            /// <summary>
            /// <para>The name of the extension.</para>
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// <para>The URL of the help documentation of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com/">https://www.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("HelpDocUrl")]
            [Validation(Required=false)]
            public string HelpDocUrl { get; set; }

            /// <summary>
            /// <para>The options defined for the extension.</para>
            /// </summary>
            [NameInMap("OptionSetting")]
            [Validation(Required=false)]
            public string OptionSetting { get; set; }

            /// <summary>
            /// <para>The parameter settings of the extension. For more information, see <a href="https://help.aliyun.com/document_detail/405354.html">Configure extension parameters</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>extension.project.disabled=projectId1,projectId2,projectId3</para>
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// <para>The workspace for testing. If the extension is being tested, the extension can be used only in the workspace for testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13552</para>
            /// </summary>
            [NameInMap("ProjectTesting")]
            [Validation(Required=false)]
            public long? ProjectTesting { get; set; }

            /// <summary>
            /// <para>The state of the extension. 0: Testing, 1: Publishing, 3: Disabled, 4: Processing, 5: Approved, 6: Approve Failed</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the request ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
