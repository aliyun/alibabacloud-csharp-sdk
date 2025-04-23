// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateRamPolicyExportTaskAttributeRequest : TeaModel {
        [NameInMap("authorizationAccountIds")]
        [Validation(Required=false)]
        public List<long?> AuthorizationAccountIds { get; set; }

        [NameInMap("authorizationActions")]
        [Validation(Required=false)]
        public List<string> AuthorizationActions { get; set; }

        [NameInMap("authorizationRegionIds")]
        [Validation(Required=false)]
        public List<string> AuthorizationRegionIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-143574fff6b316f4eb737e</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ramName</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

    }

}
