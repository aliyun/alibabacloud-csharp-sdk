// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypeRegistrationsRequest : TeaModel {
        /// <summary>
        /// <para>The entity type. Set the value to Module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Module</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the registration record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// <para>The resource type. The resource type can contain letters, digits, colons (:), and asterisks (\<em>). You can use an asterisk (\</em>) to perform a fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The registration state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IN_PROGRESS</description></item>
        /// <item><description>COMPLETE</description></item>
        /// <item><description>FAILED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
