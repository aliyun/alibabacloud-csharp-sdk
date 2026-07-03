// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetCapacityRequest : TeaModel {
        /// <summary>
        /// <para>Region where the Data Management Center for threat analysis is located. Choose a region based on where your assets are located.</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Select this if your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Select this if your assets are outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>User ID of the member whose view the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>View type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: View for the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: View for all accounts under your enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
