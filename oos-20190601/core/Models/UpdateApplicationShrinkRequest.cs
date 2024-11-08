// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of application alerts.</para>
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public string AlarmConfigShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete existing alert rules before applying the alert template. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteAlarmRulesBeforeUpdate")]
        [Validation(Required=false)]
        public bool? DeleteAlarmRulesBeforeUpdate { get; set; }

        /// <summary>
        /// <para>The description to be updated for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My-Application</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
