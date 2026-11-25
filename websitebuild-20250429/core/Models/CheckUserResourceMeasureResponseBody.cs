// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CheckUserResourceMeasureResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reasons for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Specifies whether retries are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Retries are not allowed.</description></item>
        /// <item><description>true: Retries are allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name, which is used to query the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
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
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The returned error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckUserResourceMeasureResponseBodyModule Module { get; set; }
        public class CheckUserResourceMeasureResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The target total for the current check. This parameter is returned only for APP_WORKSPACE. It is the sum of the used quota in the saved configuration and ResourceValue. If the compatible DesiredTotal is provided, this total is used directly. The used quota for questions is the sum of common and word-of-mouth questions in the saved configuration, and the used quota for competitors is the number of competitors. This parameter is empty for APP or USER checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("DesiredTotal")]
            [Validation(Required=false)]
            public long? DesiredTotal { get; set; }

            /// <summary>
            /// <para>The error code returned when the check fails. This parameter is null when the check is passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the check fails. This parameter is null when the check is passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stream push failed</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The maximum number of questions or competitors allowed by the current commodity version. This parameter is returned only for APP_WORKSPACE quantity dry runs and does not represent the remaining quota. This parameter is empty for APP or USER checks, or when the version benefits cannot be determined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public long? Limit { get; set; }

            /// <summary>
            /// <para>Indicates whether the check is passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

            /// <summary>
            /// <para>The resource code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TransitRouterVpcAttachment</para>
            /// </summary>
            [NameInMap("ResourceCode")]
            [Validation(Required=false)]
            public string ResourceCode { get; set; }

            /// <summary>
            /// <para>Indicates whether a purchasable higher version exists that can accommodate the DesiredTotal. This parameter is true only when the current version capacity is insufficient and a higher version meets the requirements. Otherwise, it is false. This parameter may be empty for APP or USER checks. This field does not indicate that an upgrade has been performed or an upgrade order has been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpgradeAvailable")]
            [Validation(Required=false)]
            public bool? UpgradeAvailable { get; set; }

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
        /// <para>System exception</para>
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
