// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class MigrateResourceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-asdasdasd****</para>
        /// </summary>
        [NameInMap("DestResourceId")]
        [Validation(Required=false)]
        public string DestResourceId { get; set; }

        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to migrate the instances to a general computing resource group. If set to true, specify the ID of the general computing resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MigrateToHybrid")]
        [Validation(Required=false)]
        public bool? MigrateToHybrid { get; set; }

    }

}
