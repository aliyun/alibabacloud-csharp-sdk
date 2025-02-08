// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListEnabledExtensionsForProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The extensions.</para>
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public List<ListEnabledExtensionsForProjectResponseBodyExtensions> Extensions { get; set; }
        public class ListEnabledExtensionsForProjectResponseBodyExtensions : TeaModel {
            /// <summary>
            /// <para>The creator of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3444434343555</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The unique code of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a94a8e23bc0b4dfab9a5e4d2f374d645</para>
            /// </summary>
            [NameInMap("ExtensionCode")]
            [Validation(Required=false)]
            public string ExtensionCode { get; set; }

            /// <summary>
            /// <para>The description of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS SQL compatible Spark engine detection</para>
            /// </summary>
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            /// <summary>
            /// <para>The name of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>max_pt function is not allowed.</para>
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// <para>The modifier of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34452335611988</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21323672*******55500</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The parameter settings of the extension. For more information, see <a href="https://help.aliyun.com/document_detail/405354.html">Configure extension parameters</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>extension.fileType.23.deploy-file.enabled=true</para>
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>529889518659842</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F2CA7ED-27E5-59EA-A8C4-F1F7A1FF0B22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
