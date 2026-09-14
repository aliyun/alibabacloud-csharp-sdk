// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public List<DescribeAppsResponseBodyAppInfos> AppInfos { get; set; }
        public class DescribeAppsResponseBodyAppInfos : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-bd5e3533</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name. This parameter takes effect only when ReportType is set to present.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app1</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The tags contained in the user application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AppTags")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppInfosAppTags> AppTags { get; set; }
            public class DescribeAppsResponseBodyAppInfosAppTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ebs</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The default time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This app is used to collect cloud disk usage statistics across the network</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether delivery to EventBridge is enabled.</para>
            /// </summary>
            [NameInMap("EventBridgeSendEnabled")]
            [Validation(Required=false)]
            public bool? EventBridgeSendEnabled { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-14T02:11:32Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>Indicates whether delivery to CloudMonitor is enabled.</para>
            /// </summary>
            [NameInMap("MonitorSendEnabled")]
            [Validation(Required=false)]
            public bool? MonitorSendEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether report sending is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReportSendEnabled")]
            [Validation(Required=false)]
            public bool? ReportSendEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether delivery to Simple Log Service (SLS) is enabled.</para>
            /// </summary>
            [NameInMap("SlsSendEnabled")]
            [Validation(Required=false)]
            public bool? SlsSendEnabled { get; set; }

            /// <summary>
            /// <para>The report subscription period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weekly</para>
            /// </summary>
            [NameInMap("SubscribePeriod")]
            [Validation(Required=false)]
            public string SubscribePeriod { get; set; }

            /// <summary>
            /// <para>The subscription status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Subscribe: subscribed.</description></item>
            /// <item><description>UnSubscribe: not subscribed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscribe</para>
            /// </summary>
            [NameInMap("SubscribeStatus")]
            [Validation(Required=false)]
            public string SubscribeStatus { get; set; }

        }

        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the %s variable in the ErrMessage error message.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1C00637-AC84-5EFD-89B5-D5CE39F0F2B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The user error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("UserCode")]
        [Validation(Required=false)]
        public string UserCode { get; set; }

    }

}
