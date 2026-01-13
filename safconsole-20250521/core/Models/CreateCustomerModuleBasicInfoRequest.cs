// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class CreateCustomerModuleBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>The display identifier of the model for customers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>module01</para>
        /// </summary>
        [NameInMap("CustomerModuleName")]
        [Validation(Required=false)]
        public string CustomerModuleName { get; set; }

        /// <summary>
        /// <para>Model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>模型描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Model deployment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PMML</para>
        /// </summary>
        [NameInMap("ModuleType")]
        [Validation(Required=false)]
        public string ModuleType { get; set; }

        /// <summary>
        /// <para>Model storage path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer/xxxxxxxxx/xxxxxxxx.pmml</para>
        /// </summary>
        [NameInMap("StorePath")]
        [Validation(Required=false)]
        public string StorePath { get; set; }

    }

}
