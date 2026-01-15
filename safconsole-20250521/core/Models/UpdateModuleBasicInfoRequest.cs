// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class UpdateModuleBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>Customer model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>456</para>
        /// </summary>
        [NameInMap("CustomerModuleId")]
        [Validation(Required=false)]
        public int? CustomerModuleId { get; set; }

        /// <summary>
        /// <para>Model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>moduleName</para>
        /// </summary>
        [NameInMap("CustomerModuleName")]
        [Validation(Required=false)]
        public string CustomerModuleName { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Module type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PMML</para>
        /// </summary>
        [NameInMap("ModuleType")]
        [Validation(Required=false)]
        public string ModuleType { get; set; }

        /// <summary>
        /// <para>Test address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/xxxxx/xxx.pmml</para>
        /// </summary>
        [NameInMap("StorePath")]
        [Validation(Required=false)]
        public string StorePath { get; set; }

    }

}
