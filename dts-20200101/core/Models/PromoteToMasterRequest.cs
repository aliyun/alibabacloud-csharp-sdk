// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class PromoteToMasterRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gad-bp162d4tp0500****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-bp1756****</para>
        /// </summary>
        [NameInMap("MasterDbInstanceId")]
        [Validation(Required=false)]
        public string MasterDbInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-bp1756****</para>
        /// </summary>
        [NameInMap("SlaveDbInstanceId")]
        [Validation(Required=false)]
        public string SlaveDbInstanceId { get; set; }

    }

}
