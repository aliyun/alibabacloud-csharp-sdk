// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppPluginConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>API status or POP error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Additional information</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance <c>wget h33E1En5.popscan.xaliyun.com</c> does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppPluginConfigResponseBodyModule Module { get; set; }
        public class GetAppPluginConfigResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Business ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Primary key</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Specific widget configuration, formatted as a JSON string. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig and the toJsonString method of its child classes. Developers should inherit this widget configuration class and implement the corresponding widget configuration. The structure of each widget configuration is identical to the MPS queue configuration structure created on the Dataphin Page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PluginConfig")]
            [Validation(Required=false)]
            public string PluginConfig { get; set; }

            /// <summary>
            /// <para>View Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>a simple test plugin</para>
            /// </summary>
            [NameInMap("PluginDesc")]
            [Validation(Required=false)]
            public string PluginDesc { get; set; }

            /// <summary>
            /// <para>ID of the attached API Gateway plugin</para>
            /// 
            /// <b>Example:</b>
            /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
            /// </summary>
            [NameInMap("PluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>Plugin Name. It can contain uppercase and lowercase English letters, Chinese characters, digits, and underscores (_). The length must be between 4 and 50 characters, and it cannot start with an underscore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf_testaccapigatewayplugin29311</para>
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
