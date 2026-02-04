// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceModuleInfoRequest : TeaModel {
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

    }

}
