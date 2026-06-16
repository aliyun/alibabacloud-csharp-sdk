// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppPluginConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance <c>wget h33E1En5.popscan.xaliyun.com</c> does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppPluginConfigResponseBodyModule Module { get; set; }
        public class GetAppPluginConfigResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The specific component configuration in JSON string format. Refer to the toJsonString method of the subclasses related to com.alibaba.dataphin.pipeline.common.facade.openapi.model.plugin.OABasePluginConfig. Developers should inherit this component configuration class and implement the corresponding component configuration. Each component configuration has the same structure as the pipeline configuration created on the Dataphin console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PluginConfig")]
            [Validation(Required=false)]
            public string PluginConfig { get; set; }

            /// <summary>
            /// <para>The description of the plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a simple test plugin</para>
            /// </summary>
            [NameInMap("PluginDesc")]
            [Validation(Required=false)]
            public string PluginDesc { get; set; }

            /// <summary>
            /// <para>The ID of the bound API gateway plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
            /// </summary>
            [NameInMap("PluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>The plugin name. The name can contain uppercase and lowercase letters, Chinese characters, digits, and underscores (_). The name must be 4 to 50 characters in length and cannot start with an underscore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf_testaccapigatewayplugin29311</para>
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
