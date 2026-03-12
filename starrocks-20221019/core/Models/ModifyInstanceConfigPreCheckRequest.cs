// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyInstanceConfigPreCheckRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("configsToAdd")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToAdd { get; set; }

        [NameInMap("configsToDelete")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToDelete { get; set; }

        [NameInMap("configsToUpdate")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToUpdate { get; set; }

    }

}
