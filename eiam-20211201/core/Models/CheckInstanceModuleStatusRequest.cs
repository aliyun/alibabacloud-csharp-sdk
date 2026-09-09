// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckInstanceModuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The level-2 module identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:ud:customField</para>
        /// </summary>
        [NameInMap("FeatureKey")]
        [Validation(Required=false)]
        public string FeatureKey { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The level-1 module identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:ud</para>
        /// </summary>
        [NameInMap("ModuleKey")]
        [Validation(Required=false)]
        public string ModuleKey { get; set; }

        /// <summary>
        /// <para>The resource label URN key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:label:template:app</para>
        /// </summary>
        [NameInMap("ResourceLabelKey")]
        [Validation(Required=false)]
        public string ResourceLabelKey { get; set; }

        /// <summary>
        /// <para>The resource label name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_ram_user_sso</para>
        /// </summary>
        [NameInMap("ResourceLabelValue")]
        [Validation(Required=false)]
        public string ResourceLabelValue { get; set; }

        /// <summary>
        /// <para>The level-3 module identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:idp:alibaba:dingtalk:pull:advanced_configuration</para>
        /// </summary>
        [NameInMap("SubFeatureKey")]
        [Validation(Required=false)]
        public string SubFeatureKey { get; set; }

    }

}
