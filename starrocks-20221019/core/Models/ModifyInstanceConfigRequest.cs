// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("AddConfigList")]
        [Validation(Required=false)]
        public string AddConfigList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;type\&quot;:\&quot;sas_analysis_online-sas-operation-log-sh-sas-event-rasp\&quot;,\&quot;configItemList\&quot;:[{\&quot;key\&quot;:\&quot;item_level\&quot;,\&quot;valueList\&quot;:[\&quot;all\&quot;]},{\&quot;key\&quot;:\&quot;alert_type\&quot;,\&quot;valueList\&quot;:[\&quot;all\&quot;]}]}]</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("DeleteConfigList")]
        [Validation(Required=false)]
        public string DeleteConfigList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-991ca6180620****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("configsToAdd")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToAdd { get; set; }

        [NameInMap("configsToDelete")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToDelete { get; set; }

        [NameInMap("configsToUpdate")]
        [Validation(Required=false)]
        public List<InstanceConfigDto> ConfigsToUpdate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("fastMode")]
        [Validation(Required=false)]
        public bool? FastMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
