// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class TriggerStackExecutionRequest : TeaModel {
        /// <summary>
        /// <para>Operation to execute  </para>
        /// <list type="bullet">
        /// <item><description>terraform plan  </description></item>
        /// <item><description>terraform apply  </description></item>
        /// <item><description>state detect</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terraform plan</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>Collection of changed files. You can specify only the folders containing changed files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("changedFolders")]
        [Validation(Required=false)]
        public List<string> ChangedFolders { get; set; }

        /// <summary>
        /// <para>Idempotent token. Format: [0-9a-zA-Z-]{1,64}. We recommend using a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Stack code path. Currently, only Stacks created through IaC templates are supported.<br>Parameter format: iacservice::{moduleId}</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iacservice::mod-xxx</para>
        /// </summary>
        [NameInMap("codePackagePath")]
        [Validation(Required=false)]
        public string CodePackagePath { get; set; }

        /// <summary>
        /// <para>Code version of the Stack to trigger</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("codeVersionId")]
        [Validation(Required=false)]
        public string CodeVersionId { get; set; }

    }

}
