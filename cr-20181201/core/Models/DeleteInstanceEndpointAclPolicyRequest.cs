// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DeleteInstanceEndpointAclPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The type of the endpoint. Set the value to Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1/32</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public string Entry { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the module that you want to access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Registry</c>: the image repository.</description></item>
        /// <item><description><c>Chart</c>: a Helm chart.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Chart</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
