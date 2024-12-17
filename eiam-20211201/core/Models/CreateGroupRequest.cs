// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the group. The value can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The external ID of the group, which can be used to associate the group with an external system. By default, the external ID is the group ID. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("GroupExternalId")]
        [Validation(Required=false)]
        public string GroupExternalId { get; set; }

        /// <summary>
        /// <para>The name of the group. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

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

    }

}
