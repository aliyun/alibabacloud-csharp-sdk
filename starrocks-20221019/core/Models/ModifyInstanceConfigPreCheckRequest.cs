// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyInstanceConfigPreCheckRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The configurations to add.</para>
        /// </summary>
        [NameInMap("configsToAdd")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToAdd { get; set; }

        /// <summary>
        /// <para>The configurations to delete.</para>
        /// </summary>
        [NameInMap("configsToDelete")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToDelete { get; set; }

        /// <summary>
        /// <para>The configurations to update.</para>
        /// </summary>
        [NameInMap("configsToUpdate")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToUpdate { get; set; }

    }

}
