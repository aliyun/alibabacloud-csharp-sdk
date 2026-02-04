// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckInstanceModuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>二级模块标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:ud:customField</para>
        /// </summary>
        [NameInMap("FeatureKey")]
        [Validation(Required=false)]
        public string FeatureKey { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>一级模块标识，必填</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:ud</para>
        /// </summary>
        [NameInMap("ModuleKey")]
        [Validation(Required=false)]
        public string ModuleKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:license:module:idp:alibaba:dingtalk:pull:advanced_configuration</para>
        /// </summary>
        [NameInMap("SubFeatureKey")]
        [Validation(Required=false)]
        public string SubFeatureKey { get; set; }

    }

}
