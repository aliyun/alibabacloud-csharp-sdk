// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppInstanceEntitlementResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
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
        /// <para>ish-intelligence-store-platform-admin-web</para>
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
        /// <para>The dynamic error message, which is used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error arguments.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppInstanceEntitlementResponseBodyModule Module { get; set; }
        public class GetAppInstanceEntitlementResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business ID of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The list of all entitlement items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetAppInstanceEntitlementResponseBodyModuleItems> Items { get; set; }
            public class GetAppInstanceEntitlementResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether an instance is allocated.</para>
                /// </summary>
                [NameInMap("Allocated")]
                [Validation(Required=false)]
                public bool? Allocated { get; set; }

                /// <summary>
                /// <para>Indicates whether this entitlement item is currently available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// <para>The code of the entitlement item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Indicates whether the configuration is complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Configured")]
                [Validation(Required=false)]
                public bool? Configured { get; set; }

                /// <summary>
                /// <para>Indicates whether the edition grants this entitlement item.</para>
                /// </summary>
                [NameInMap("Entitled")]
                [Validation(Required=false)]
                public bool? Entitled { get; set; }

                /// <summary>
                /// <para>The feature source type. Valid values: PLUGIN, SKILL, CHANNEL, and SYSTEM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FeatureType")]
                [Validation(Required=false)]
                public string FeatureType { get; set; }

                /// <summary>
                /// <para>The runtime instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>waf_v2intl_public_intl-sg-i5c43rcpw04</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the entitlement item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4e46d24b56bfa944b5e6f2305715bc4e.jpg</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The plug-in ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alipay-isv</para>
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>The total quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public long? Quota { get; set; }

                /// <summary>
                /// <para>The remaining amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Remaining")]
                [Validation(Required=false)]
                public long? Remaining { get; set; }

                /// <summary>
                /// <para>The association code of the resource domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SmsCount</para>
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values: QUOTA and LIMIT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filesystem</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public bool? Running { get; set; }

                /// <summary>
                /// <para>The entitlement type. Valid values: FEATURE, RESOURCE, and RUNTIME.</para>
                /// 
                /// <b>Example:</b>
                /// <para>question</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The usage percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UsagePercent")]
                [Validation(Required=false)]
                public int? UsagePercent { get; set; }

                /// <summary>
                /// <para>The used amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3295422523872</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

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
        /// <para>The root error message.</para>
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
