// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ExportApplicationConfigsResponseBody : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ExportApplicationConfigsResponseBodyApplicationConfigs> ApplicationConfigs { get; set; }
        public class ExportApplicationConfigsResponseBodyApplicationConfigs : TeaModel {
            /// <summary>
            /// <para>应用名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>YARN</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>文件名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>yarn-site.xml</para>
            /// </summary>
            [NameInMap("ConfigFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// <para>文件内容，base64加密。</para>
            /// 
            /// <b>Example:</b>
            /// <para>export key=value</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
