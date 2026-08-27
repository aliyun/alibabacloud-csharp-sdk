// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetResourceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the default version. Specify this parameter to set the default version for the resource type.</para>
        /// <remarks>
        /// <para>You can specify either VersionId or DefaultVersionId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DefaultVersionId")]
        [Validation(Required=false)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// <para>The description of the resource type or a version of the resource type. The description can be up to 512 characters in length.</para>
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
        /// <para>The version ID. Specify this parameter to modify a specific version of the resource type. Otherwise, the description of the resource type itself is modified.</para>
        /// <remarks>
        /// <para>You can specify either VersionId or DefaultVersionId.</para>
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
