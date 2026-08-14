// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class PromoteToMasterRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gad-bp162d4tp0500****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Primary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1756****</para>
        /// </summary>
        [NameInMap("MasterDbInstanceId")]
        [Validation(Required=false)]
        public string MasterDbInstanceId { get; set; }

        /// <summary>
        /// <para>Region ID. Specify this parameter to indicate the region where the instance resides. For more information, see the list of supported regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Secondary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1756****</para>
        /// </summary>
        [NameInMap("SlaveDbInstanceId")]
        [Validation(Required=false)]
        public string SlaveDbInstanceId { get; set; }

    }

}
