// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationPromptRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Usage note: Only applications of the mem0 type support prompt operations. You can verify this by checking the ApplicationType field by calling DescribeApplicationAttribute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The prompt ID. The value is an identifier that starts with papt-.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>papt-f9lajgw765f4fnrzn1</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// <para>The prompt name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prompt name</para>
        /// </summary>
        [NameInMap("PromptName")]
        [Validation(Required=false)]
        public string PromptName { get; set; }

        /// <summary>
        /// <para>The prompt content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prompt value</para>
        /// </summary>
        [NameInMap("PromptValue")]
        [Validation(Required=false)]
        public string PromptValue { get; set; }

    }

}
