// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetResourceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the default version. You can use this parameter to specify the default version of the resource type.</para>
        /// <remarks>
        /// <para>You can specify only one of the VersionId and DefaultVersionId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DefaultVersionId")]
        [Validation(Required=false)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// <para>The description of the resource type or resource type version. The description can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The version ID. If you want to modify a version of the resource type, you must specify this parameter. If you do not specify this parameter, only the resource type is modified.</para>
        /// <remarks>
        /// <para>You can specify only one of the VersionId and DefaultVersionId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
