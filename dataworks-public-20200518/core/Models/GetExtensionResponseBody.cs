// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetExtensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The extension details.</para>
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
                /// <para>The event code of the extension point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>commit-file</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The event name of the extension point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File submission pre-event</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

            }

            /// <summary>
            /// <para>The URL of the extension details page. Extension users can use this URL to view the details of the blocked process.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>File change event</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>This is a description</para>
            /// </summary>
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            /// <summary>
            /// <para>The name of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extension name</para>
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// <para>The URL of the help documentation for the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com/">https://www.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("HelpDocUrl")]
            [Validation(Required=false)]
            public string HelpDocUrl { get; set; }

            /// <summary>
            /// <para>The option settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Option configuration</para>
            /// </summary>
            [NameInMap("OptionSetting")]
            [Validation(Required=false)]
            public string OptionSetting { get; set; }

            /// <summary>
            /// <para>The parameter settings. For more information, see <a href="https://help.aliyun.com/document_detail/405354.html">Extension parameter settings</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>extension.project.disabled=projectId1,projectId2,projectId3</para>
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// <para>The workspace used for testing. When the extension is in the testing state, only the testing workspace can use the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1355211</para>
            /// </summary>
            [NameInMap("ProjectTesting")]
            [Validation(Required=false)]
            public long? ProjectTesting { get; set; }

            /// <summary>
            /// <para>The status of the extension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: testing</description></item>
            /// <item><description>1: online</description></item>
            /// <item><description>3: disabled</description></item>
            /// <item><description>4: pending approval</description></item>
            /// <item><description>5: approved</description></item>
            /// <item><description>6: rejected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
