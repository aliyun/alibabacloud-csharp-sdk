// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationSsoFormParamsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_11111</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The parameters for creating the application template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationTemplateParams")]
        [Validation(Required=false)]
        public List<UpdateApplicationSsoFormParamsRequestApplicationTemplateParams> ApplicationTemplateParams { get; set; }
        public class UpdateApplicationSsoFormParamsRequestApplicationTemplateParams : TeaModel {
            /// <summary>
            /// <para>The name of a parameter for creating the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyunUid</para>
            /// </summary>
            [NameInMap("TemplateParamName")]
            [Validation(Required=false)]
            public string TemplateParamName { get; set; }

            /// <summary>
            /// <para>The value of the parameter for creating the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("TemplateParamValue")]
            [Validation(Required=false)]
            public string TemplateParamValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eiam-111ccc1111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
