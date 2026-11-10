// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class DeleteCloudPermissionTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The ID of the permission template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateId")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
