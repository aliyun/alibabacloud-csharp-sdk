// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteMetaEntityDefRequest : TeaModel {
        /// <summary>
        /// <para>The entity type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Specifies whether to force delete the entity definition. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatically deletes all entity objects created under this entity type.</description></item>
        /// <item><description>false: Checks whether entity objects exist under this entity type. If objects exist, the deletion is failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
