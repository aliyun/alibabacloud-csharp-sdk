// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance whose name or description you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new name of the instance. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name of the instance must be unique in the region where the instance is deployed.</description></item>
        /// <item><description>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), underscores (_), and Chinese characters.</description></item>
        /// <item><description>If you do not configure this parameter, the instance name remains unchanged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Updatedname</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The updated description of the instance. If you do not configure this parameter, the instance description remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updateddescription</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
