// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DeleteInstanceEndpointAclPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint type. Only Internet is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        [NameInMap("Entries")]
        [Validation(Required=false)]
        public string EntriesShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The IP CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1/32</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        [Obsolete]
        public string Entry { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The module for which the access policy is set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Registry</c>: access to the image repository</para>
        /// </description></item>
        /// <item><description><para><c>Chart</c>: access to Helm Chart</para>
        /// </description></item>
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
