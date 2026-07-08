// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppPublishStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access is denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppPublishStatusResponseBodyModule Module { get; set; }
        public class GetAppPublishStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Indicates whether quick rollback is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanQuickRevert")]
            [Validation(Required=false)]
            public string CanQuickRevert { get; set; }

            /// <summary>
            /// <para>The current step of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_CHECK</para>
            /// </summary>
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public string CurrentStep { get; set; }

            /// <summary>
            /// <para>The deployment channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PC,WEAPP</para>
            /// </summary>
            [NameInMap("DeployChannel")]
            [Validation(Required=false)]
            public string DeployChannel { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/bak-&gt;serverless.handler(2020091300200279)</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The publish process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("ErrorStep")]
            [Validation(Required=false)]
            public string ErrorStep { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is complete.</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>Indicates whether the call is successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The call is successful.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The call failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            /// <summary>
            /// <para>The additional description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>common notify successfully.</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The sort type. Valid values: ASC and DESC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESC</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The task completion percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The publish number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PublishNumber")]
            [Validation(Required=false)]
            public string PublishNumber { get; set; }

            /// <summary>
            /// <para>The publish order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PublishOrderId")]
            [Validation(Required=false)]
            public long? PublishOrderId { get; set; }

            /// <summary>
            /// <para>The scheduled publish time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The site ID. You can obtain the site ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>865181640657408</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            /// <summary>
            /// <para>The error level. Valid values: FATAL, ERROR, WARNING, and CRITICAL.</para>
            /// </summary>
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<string> Steps { get; set; }

            [NameInMap("Subchannel")]
            [Validation(Required=false)]
            public string Subchannel { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
